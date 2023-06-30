using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class AdditionalLightsShadowCasterPass : ScriptableRenderPass
	{
		private static class AdditionalShadowsConstantBuffer
		{
			public static int _AdditionalLightsWorldToShadow;

			public static int _AdditionalShadowParams;

			public static int _AdditionalShadowOffset0;

			public static int _AdditionalShadowOffset1;

			public static int _AdditionalShadowOffset2;

			public static int _AdditionalShadowOffset3;

			public static int _AdditionalShadowFadeParams;

			public static int _AdditionalShadowmapSize;
		}

		internal struct ShadowResolutionRequest
		{
			public int visibleLightIndex;

			public int perLightShadowSliceIndex;

			public int requestedResolution;

			public bool softShadow;

			public bool pointLightShadow;

			public int offsetX;

			public int offsetY;

			public int allocatedResolution;

			public ShadowResolutionRequest(int _visibleLightIndex, int _perLightShadowSliceIndex, int _requestedResolution, bool _softShadow, bool _pointLightShadow)
			{
			}
		}

		[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsBufferId was deprecated. Shadow slice matrix is now passed to the GPU using an entry in buffer m_AdditionalLightsWorldToShadow_SSBO", false)]
		public static int m_AdditionalShadowsBufferId;

		[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsIndicesId was deprecated. Shadow slice index is now passed to the GPU using last member of an entry in buffer m_AdditionalShadowParams_SSBO", false)]
		public static int m_AdditionalShadowsIndicesId;

		private static readonly Vector4 c_DefaultShadowParams;

		private static int m_AdditionalLightsWorldToShadow_SSBO;

		private static int m_AdditionalShadowParams_SSBO;

		private bool m_UseStructuredBuffer;

		private const int k_ShadowmapBufferBits = 16;

		private RenderTargetHandle m_AdditionalLightsShadowmap;

		internal RenderTexture m_AdditionalLightsShadowmapTexture;

		private float m_MaxShadowDistanceSq;

		private float m_CascadeBorder;

		private ShadowSliceData[] m_AdditionalLightsShadowSlices;

		private int[] m_VisibleLightIndexToAdditionalLightIndex;

		private int[] m_AdditionalLightIndexToVisibleLightIndex;

		private List<int> m_ShadowSliceToAdditionalLightIndex;

		private List<int> m_GlobalShadowSliceIndexToPerLightShadowSliceIndex;

		private Vector4[] m_AdditionalLightIndexToShadowParams;

		private Matrix4x4[] m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix;

		private List<ShadowResolutionRequest> m_ShadowResolutionRequests;

		private float[] m_VisibleLightIndexToCameraSquareDistance;

		private ShadowResolutionRequest[] m_SortedShadowResolutionRequests;

		private int[] m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex;

		private List<RectInt> m_UnusedAtlasSquareAreas;

		private bool m_CreateEmptyShadowmap;

		private ProfilingSampler m_ProfilingSetupSampler;

		private const float LightTypeIdentifierInShadowParams_Spot = 0f;

		private const float LightTypeIdentifierInShadowParams_Point = 1f;

		private const int kMinimumPunctualLightHardShadowResolution = 8;

		private const int kMinimumPunctualLightSoftShadowResolution = 16;

		private Dictionary<int, ulong> m_ShadowRequestsHashes;

		private int MAX_PUNCTUAL_LIGHT_SHADOW_SLICES_IN_UBO => 0;

		public AdditionalLightsShadowCasterPass(RenderPassEvent evt)
		{
		}

		private int GetPunctualLightShadowSlicesCount(in LightType lightType)
		{
			return 0;
		}

		internal static float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels)
		{
			return 0f;
		}

		private int MinimalPunctualLightShadowResolution(bool softShadow)
		{
			return 0;
		}

		internal static float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering)
		{
			return 0f;
		}

		internal void InsertionSort(ShadowResolutionRequest[] array, int startIndex, int lastIndex)
		{
		}

		private int EstimateScaleFactorNeededToFitAllShadowsInAtlas(in ShadowResolutionRequest[] shadowResolutionRequests, int endIndex, int atlasWidth)
		{
			return 0;
		}

		private void AtlasLayout(int atlasSize, int totalShadowSlicesCount, int estimatedScaleFactor)
		{
		}

		private ulong ResolutionLog2ForHash(int resolution)
		{
			return 0uL;
		}

		private ulong ComputeShadowRequestHash(ref RenderingData renderingData)
		{
			return 0uL;
		}

		public bool Setup(ref RenderingData renderingData)
		{
			return false;
		}

		private bool SetupForEmptyRendering(ref RenderingData renderingData)
		{
			return false;
		}

		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		public int GetShadowLightIndexFromLightIndex(int visibleLightIndex)
		{
			return 0;
		}

		private void Clear()
		{
		}

		private void SetEmptyAdditionalShadowmapAtlas(ref ScriptableRenderContext context)
		{
		}

		private void RenderAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref CullingResults cullResults, ref LightData lightData, ref ShadowData shadowData)
		{
		}

		private void SetupAdditionalLightsShadowReceiverConstants(CommandBuffer cmd, ref ShadowData shadowData, bool softShadows)
		{
		}

		private bool IsValidShadowCastingLight(ref LightData lightData, int i)
		{
			return false;
		}
	}
}
