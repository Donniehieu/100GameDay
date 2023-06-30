using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class DepthOnlyPass : ScriptableRenderPass
	{
		private static readonly ShaderTagId k_ShaderTagId;

		private FilteringSettings m_FilteringSettings;

		private RenderTargetHandle depthAttachmentHandle
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

		internal RenderTextureDescriptor descriptor
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

		internal ShaderTagId shaderTagId
		{
			[CompilerGenerated]
			get
			{
				return default(ShaderTagId);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DepthOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask)
		{
		}

		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle depthAttachmentHandle)
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
