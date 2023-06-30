using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.XR;

namespace UnityEngine.Rendering.Universal
{
	internal class XRPass
	{
		internal delegate void CustomMirrorView(XRPass pass, CommandBuffer cmd, RenderTexture rt, Rect viewport);

		internal List<XRView> views;

		private static RenderTargetIdentifier invalidRT;

		private Material occlusionMeshMaterial;

		private Mesh occlusionMeshCombined;

		private int occlusionMeshCombinedHashCode;

		private CustomMirrorView customMirrorView;

		private const string k_XRCustomMirrorTag = "XR Custom Mirror View";

		private static ProfilingSampler _XRCustomMirrorProfilingSampler;

		private const string k_XROcclusionTag = "XR Occlusion Mesh";

		private static ProfilingSampler _XROcclusionProfilingSampler;

		private Matrix4x4[] stereoProjectionMatrix;

		private Matrix4x4[] stereoViewMatrix;

		private Matrix4x4[] stereoCameraProjectionMatrix;

		internal static readonly int UNITY_STEREO_MATRIX_V;

		internal static readonly int UNITY_STEREO_MATRIX_IV;

		internal static readonly int UNITY_STEREO_MATRIX_VP;

		internal static readonly int UNITY_STEREO_MATRIX_IVP;

		internal bool enabled => false;

		internal bool xrSdkEnabled
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal bool copyDepth
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal int multipassId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal int cullingPassId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal RenderTargetIdentifier renderTarget
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal RenderTextureDescriptor renderTargetDesc
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal bool renderTargetValid => false;

		internal bool renderTargetIsRenderTexture
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal bool isLateLatchEnabled
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

		internal bool canMarkLateLatch
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

		internal bool hasMarkedLateLatch
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

		internal ScriptableCullingParameters cullingParams
		{
			[CompilerGenerated]
			get
			{
				return default(ScriptableCullingParameters);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal int viewCount => 0;

		internal bool singlePassEnabled => false;

		internal bool isOcclusionMeshSupported => false;

		internal bool hasValidOcclusionMesh => false;

		internal Matrix4x4 GetProjMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		internal Matrix4x4 GetViewMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		internal int GetTextureArraySlice(int viewIndex = 0)
		{
			return 0;
		}

		internal Rect GetViewport(int viewIndex = 0)
		{
			return default(Rect);
		}

		internal void SetCustomMirrorView(CustomMirrorView callback)
		{
		}

		internal static XRPass Create(XRPassCreateInfo createInfo)
		{
			return null;
		}

		internal void UpdateView(int viewId, XRDisplaySubsystem.XRRenderPass xrSdkRenderPass, XRDisplaySubsystem.XRRenderParameter xrSdkRenderParameter)
		{
		}

		internal void UpdateView(int viewId, Matrix4x4 proj, Matrix4x4 view, Rect vp, int textureArraySlice = -1)
		{
		}

		internal void UpdateCullingParams(int cullingPassId, ScriptableCullingParameters cullingParams)
		{
		}

		internal void AddView(Matrix4x4 proj, Matrix4x4 view, Rect vp, int textureArraySlice = -1)
		{
		}

		internal static XRPass Create(XRDisplaySubsystem.XRRenderPass xrRenderPass, int multipassId, ScriptableCullingParameters cullingParameters, Material occlusionMeshMaterial)
		{
			return null;
		}

		internal void AddView(XRDisplaySubsystem.XRRenderPass xrSdkRenderPass, XRDisplaySubsystem.XRRenderParameter xrSdkRenderParameter)
		{
		}

		internal static void Release(XRPass xrPass)
		{
		}

		internal void AddViewInternal(XRView xrView)
		{
		}

		internal void UpdateOcclusionMesh()
		{
		}

		private bool TryGetOcclusionMeshCombinedHashCode(out int hashCode)
		{
			hashCode = default(int);
			return false;
		}

		private void CreateOcclusionMeshCombined()
		{
		}

		internal void StartSinglePass(CommandBuffer cmd)
		{
		}

		internal void StopSinglePass(CommandBuffer cmd)
		{
		}

		internal void EndCamera(CommandBuffer cmd, CameraData cameraData)
		{
		}

		internal void RenderOcclusionMesh(CommandBuffer cmd)
		{
		}

		internal void UpdateGPUViewAndProjectionMatrices(CommandBuffer cmd, ref CameraData cameraData, bool isRenderToTexture)
		{
		}

		internal void MarkLateLatchShaderProperties(CommandBuffer cmd, ref CameraData cameraData)
		{
		}

		internal void UnmarkLateLatchShaderProperties(CommandBuffer cmd, ref CameraData cameraData)
		{
		}
	}
}
