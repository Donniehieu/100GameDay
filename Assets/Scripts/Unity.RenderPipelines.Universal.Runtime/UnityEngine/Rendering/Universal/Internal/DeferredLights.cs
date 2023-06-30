using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal.Internal
{
	internal class DeferredLights
	{
		internal static class ShaderConstants
		{
			public static readonly int _LitStencilRef;

			public static readonly int _LitStencilReadMask;

			public static readonly int _LitStencilWriteMask;

			public static readonly int _SimpleLitStencilRef;

			public static readonly int _SimpleLitStencilReadMask;

			public static readonly int _SimpleLitStencilWriteMask;

			public static readonly int _StencilRef;

			public static readonly int _StencilReadMask;

			public static readonly int _StencilWriteMask;

			public static readonly int _LitPunctualStencilRef;

			public static readonly int _LitPunctualStencilReadMask;

			public static readonly int _LitPunctualStencilWriteMask;

			public static readonly int _SimpleLitPunctualStencilRef;

			public static readonly int _SimpleLitPunctualStencilReadMask;

			public static readonly int _SimpleLitPunctualStencilWriteMask;

			public static readonly int _LitDirStencilRef;

			public static readonly int _LitDirStencilReadMask;

			public static readonly int _LitDirStencilWriteMask;

			public static readonly int _SimpleLitDirStencilRef;

			public static readonly int _SimpleLitDirStencilReadMask;

			public static readonly int _SimpleLitDirStencilWriteMask;

			public static readonly int _ClearStencilRef;

			public static readonly int _ClearStencilReadMask;

			public static readonly int _ClearStencilWriteMask;

			public static readonly int UDepthRanges;

			public static readonly int _DepthRanges;

			public static readonly int _DownsamplingWidth;

			public static readonly int _DownsamplingHeight;

			public static readonly int _SourceShiftX;

			public static readonly int _SourceShiftY;

			public static readonly int _TileShiftX;

			public static readonly int _TileShiftY;

			public static readonly int _tileXCount;

			public static readonly int _DepthRangeOffset;

			public static readonly int _BitmaskTex;

			public static readonly int UTileList;

			public static readonly int _TileList;

			public static readonly int UPunctualLightBuffer;

			public static readonly int _PunctualLightBuffer;

			public static readonly int URelLightList;

			public static readonly int _RelLightList;

			public static readonly int _TilePixelWidth;

			public static readonly int _TilePixelHeight;

			public static readonly int _InstanceOffset;

			public static readonly int _DepthTex;

			public static readonly int _DepthTexSize;

			public static readonly int _ScreenToWorld;

			public static readonly int _unproject0;

			public static readonly int _unproject1;

			public static int _MainLightPosition;

			public static int _MainLightColor;

			public static int _MainLightLayerMask;

			public static int _SpotLightScale;

			public static int _SpotLightBias;

			public static int _SpotLightGuard;

			public static int _LightPosWS;

			public static int _LightColor;

			public static int _LightAttenuation;

			public static int _LightOcclusionProbInfo;

			public static int _LightDirection;

			public static int _LightFlags;

			public static int _ShadowLightIndex;

			public static int _LightLayerMask;

			public static int _CookieLightIndex;
		}

		private struct CullLightsJob : IJob
		{
			public DeferredTiler tiler;

			[NativeDisableContainerSafetyRestriction]
			[ReadOnly]
			public NativeArray<DeferredTiler.PrePunctualLight> prePunctualLights;

			[ReadOnly]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<ushort> coarseTiles;

			[ReadOnly]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<uint> coarseTileHeaders;

			public int coarseHeaderOffset;

			public int istart;

			public int iend;

			public int jstart;

			public int jend;

			public void Execute()
			{
			}
		}

		private struct DrawCall
		{
			public ComputeBuffer tileList;

			public ComputeBuffer punctualLightBuffer;

			public ComputeBuffer relLightList;

			public int tileListSize;

			public int punctualLightBufferSize;

			public int relLightListSize;

			public int instanceOffset;

			public int instanceCount;
		}

		internal enum TileDeferredPasses
		{
			PunctualLit = 0,
			PunctualSimpleLit = 1
		}

		internal enum StencilDeferredPasses
		{
			StencilVolume = 0,
			PunctualLit = 1,
			PunctualSimpleLit = 2,
			DirectionalLit = 3,
			DirectionalSimpleLit = 4,
			ClearStencilPartial = 5,
			Fog = 6,
			SSAOOnly = 7
		}

		internal struct InitParams
		{
			public Material tileDepthInfoMaterial;

			public Material tileDeferredMaterial;

			public Material stencilDeferredMaterial;

			public LightCookieManager lightCookieManager;
		}

		private static readonly string[] k_GBufferNames;

		private static readonly string[] k_TileDeferredPassNames;

		private static readonly string[] k_StencilDeferredPassNames;

		private static readonly ushort k_InvalidLightOffset;

		private static readonly string k_SetupLights;

		private static readonly string k_DeferredPass;

		private static readonly string k_TileDepthInfo;

		private static readonly string k_DeferredTiledPass;

		private static readonly string k_DeferredStencilPass;

		private static readonly string k_DeferredFogPass;

		private static readonly string k_ClearStencilPartial;

		private static readonly string k_SetupLightConstants;

		private static readonly float kStencilShapeGuard;

		private static readonly ProfilingSampler m_ProfilingSetupLights;

		private static readonly ProfilingSampler m_ProfilingDeferredPass;

		private static readonly ProfilingSampler m_ProfilingTileDepthInfo;

		private static readonly ProfilingSampler m_ProfilingSetupLightConstants;

		private bool m_AccurateGbufferNormals;

		private int m_CachedRenderWidth;

		private int m_CachedRenderHeight;

		private Matrix4x4 m_CachedProjectionMatrix;

		private DeferredTiler[] m_Tilers;

		private int[] m_TileDataCapacities;

		private bool m_HasTileVisLights;

		private NativeArray<ushort> m_stencilVisLights;

		private NativeArray<ushort> m_stencilVisLightOffsets;

		private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;

		private Mesh m_SphereMesh;

		private Mesh m_HemisphereMesh;

		private Mesh m_FullscreenMesh;

		private int m_MaxDepthRangePerBatch;

		private int m_MaxTilesPerBatch;

		private int m_MaxPunctualLightPerBatch;

		private int m_MaxRelLightIndicesPerBatch;

		private Material m_TileDepthInfoMaterial;

		private Material m_TileDeferredMaterial;

		private Material m_StencilDeferredMaterial;

		private int[] m_StencilDeferredPasses;

		private int[] m_TileDeferredPasses;

		private Matrix4x4[] m_ScreenToWorld;

		private ProfilingSampler m_ProfilingSamplerDeferredTiledPass;

		private ProfilingSampler m_ProfilingSamplerDeferredStencilPass;

		private ProfilingSampler m_ProfilingSamplerDeferredFogPass;

		private ProfilingSampler m_ProfilingSamplerClearStencilPartialPass;

		private LightCookieManager m_LightCookieManager;

		internal int GBufferAlbedoIndex => 0;

		internal int GBufferSpecularMetallicIndex => 0;

		internal int GBufferNormalSmoothnessIndex => 0;

		internal int GBufferLightingIndex => 0;

		internal int GbufferDepthIndex => 0;

		internal int GBufferShadowMask => 0;

		internal int GBufferRenderingLayers => 0;

		internal int GBufferSliceCount => 0;

		internal bool UseShadowMask => false;

		internal bool UseRenderingLayers => false;

		internal bool UseRenderPass
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal bool HasDepthPrepass
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal bool HasNormalPrepass
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal bool IsOverlay
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal bool AccurateGbufferNormals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool TiledDeferredShading
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal MixedLightingSetup MixedLightingSetup
		{
			[CompilerGenerated]
			get
			{
				return default(MixedLightingSetup);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal bool UseJobSystem
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal int RenderWidth
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal int RenderHeight
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal RenderTargetHandle[] GbufferAttachments
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal RenderTargetIdentifier[] DeferredInputAttachments
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal bool[] DeferredInputIsTransient
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal RenderTargetHandle DepthAttachment
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal RenderTargetHandle DepthCopyTexture
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal RenderTargetHandle DepthInfoTexture
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal RenderTargetHandle TileDepthInfoTexture
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal RenderTargetIdentifier[] GbufferAttachmentIdentifiers
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal GraphicsFormat[] GbufferFormats
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal RenderTargetIdentifier DepthAttachmentIdentifier
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal RenderTargetIdentifier DepthCopyTextureIdentifier
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal RenderTargetIdentifier DepthInfoTextureIdentifier
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal RenderTargetIdentifier TileDepthInfoTextureIdentifier
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal GraphicsFormat GetGBufferFormat(int index)
		{
			return default(GraphicsFormat);
		}

		internal DeferredLights(InitParams initParams, bool useNativeRenderPass = false)
		{
		}

		internal unsafe ref DeferredTiler GetTiler(int i)
		{
			return ref *(DeferredTiler*)null;
		}

		internal void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		internal void ResolveMixedLightingMode(ref RenderingData renderingData)
		{
		}

		internal void DisableFramebufferFetchInput()
		{
		}

		internal void CreateGbufferAttachments()
		{
		}

		internal bool IsRuntimeSupportedThisFrame()
		{
			return false;
		}

		public void Setup(ref RenderingData renderingData, AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass, bool hasDepthPrepass, bool hasNormalPrepass, RenderTargetHandle depthCopyTexture, RenderTargetHandle depthInfoTexture, RenderTargetHandle tileDepthInfoTexture, RenderTargetHandle depthAttachment, RenderTargetHandle colorAttachment)
		{
		}

		public void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		internal static StencilState OverwriteStencil(StencilState s, int stencilWriteMask)
		{
			return default(StencilState);
		}

		internal static RenderStateBlock OverwriteStencil(RenderStateBlock block, int stencilWriteMask, int stencilRef)
		{
			return default(RenderStateBlock);
		}

		internal bool HasTileLights()
		{
			return false;
		}

		internal bool HasTileDepthRangeExtraPass()
		{
			return false;
		}

		internal void ExecuteTileDepthInfoPass(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		internal void ExecuteDownsampleBitmaskPass(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		internal void ClearStencilPartial(CommandBuffer cmd)
		{
		}

		internal void ExecuteDeferredPass(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private void SetupShaderLightConstants(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData)
		{
		}

		private void SetupMatrixConstants(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		private void SortLights(ref NativeArray<DeferredTiler.PrePunctualLight> prePunctualLights)
		{
		}

		private bool CheckHasTileLights(ref NativeArray<VisibleLight> visibleLights)
		{
			return false;
		}

		private void PrecomputeLights(out NativeArray<DeferredTiler.PrePunctualLight> prePunctualLights, out NativeArray<ushort> stencilVisLights, out NativeArray<ushort> stencilVisLightOffsets, ref NativeArray<VisibleLight> visibleLights, bool hasAdditionalLights, Matrix4x4 view, bool isOrthographic, float zNear)
		{
			prePunctualLights = default(NativeArray<DeferredTiler.PrePunctualLight>);
			stencilVisLights = default(NativeArray<ushort>);
			stencilVisLightOffsets = default(NativeArray<ushort>);
		}

		private void RenderTileLights(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		private bool HasStencilLightsOfType(LightType type)
		{
			return false;
		}

		private void RenderStencilLights(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		private void RenderStencilDirectionalLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights, int mainLightIndex)
		{
		}

		private void RenderStencilPointLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights)
		{
		}

		private void RenderStencilSpotLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights)
		{
		}

		private void RenderSSAOBeforeShading(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		private void RenderFog(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		private int TrimLights(ref NativeArray<ushort> trimmedLights, ref NativeArray<ushort> tiles, int offset, int lightCount, ref BitArray usedLights)
		{
			return 0;
		}

		private void StorePunctualLightData(ref NativeArray<uint4> punctualLightBuffer, int storeIndex, ref NativeArray<VisibleLight> visibleLights, int index)
		{
		}

		private void StoreTileData(ref NativeArray<uint4> tileList, int storeIndex, uint tileID, uint listBitMask, ushort relLightOffset, ushort lightCount)
		{
		}

		[MethodImpl(256)]
		private bool IsTileLight(VisibleLight visibleLight)
		{
			return false;
		}

		private void InitTileDeferredMaterial()
		{
		}

		private void InitStencilDeferredMaterial()
		{
		}

		private static Mesh CreateSphereMesh()
		{
			return null;
		}

		private static Mesh CreateHemisphereMesh()
		{
			return null;
		}

		private static Mesh CreateFullscreenMesh()
		{
			return null;
		}

		private static int Align(int s, int alignment)
		{
			return 0;
		}

		private static uint PackTileID(uint i, uint j)
		{
			return 0u;
		}

		private static uint FloatToUInt(float val)
		{
			return 0u;
		}

		private static uint Half2ToUInt(float x, float y)
		{
			return 0u;
		}
	}
}
