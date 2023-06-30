using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal
{
	internal class DBufferRenderPass : ScriptableRenderPass
	{
		private static string[] s_DBufferNames;

		private static string s_DBufferDepthName;

		private DecalDrawDBufferSystem m_DrawSystem;

		private DBufferSettings m_Settings;

		private Material m_DBufferClear;

		private FilteringSettings m_FilteringSettings;

		private List<ShaderTagId> m_ShaderTagIdList;

		private int m_DBufferCount;

		private ProfilingSampler m_ProfilingSampler;

		internal DeferredLights deferredLights
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

		private bool isDeferred => false;

		internal RenderTargetIdentifier[] dBufferColorIndentifiers
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal RenderTargetIdentifier dBufferDepthIndentifier
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

		internal RenderTargetIdentifier cameraDepthTextureIndentifier
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

		internal RenderTargetIdentifier cameraDepthAttachmentIndentifier
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

		public DBufferRenderPass(Material dBufferClear, DBufferSettings settings, DecalDrawDBufferSystem drawSystem)
		{
		}

		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private void ClearDBuffers(CommandBuffer cmd, in CameraData cameraData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
}
