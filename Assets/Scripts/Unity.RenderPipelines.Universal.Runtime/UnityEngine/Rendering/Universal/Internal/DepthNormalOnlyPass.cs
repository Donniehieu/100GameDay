using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class DepthNormalOnlyPass : ScriptableRenderPass
	{
		private FilteringSettings m_FilteringSettings;

		private int m_RendererMSAASamples;

		private static readonly List<ShaderTagId> k_DepthNormals;

		internal RenderTextureDescriptor normalDescriptor
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal RenderTextureDescriptor depthDescriptor
		{
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal bool allocateDepth
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

		internal bool allocateNormal
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

		internal List<ShaderTagId> shaderTagIds
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

		private RenderTargetHandle depthHandle
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

		private RenderTargetHandle normalHandle
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

		public DepthNormalOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask)
		{
		}

		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle depthHandle, RenderTargetHandle normalHandle)
		{
		}

		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
}
