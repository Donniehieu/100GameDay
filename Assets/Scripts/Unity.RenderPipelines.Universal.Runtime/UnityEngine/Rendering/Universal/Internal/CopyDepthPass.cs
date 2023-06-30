using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class CopyDepthPass : ScriptableRenderPass
	{
		private Material m_CopyDepthMaterial;

		private RenderTargetHandle source
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

		private RenderTargetHandle destination
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

		internal bool AllocateRT
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

		internal int MssaSamples
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

		public CopyDepthPass(RenderPassEvent evt, Material copyDepthMaterial)
		{
		}

		public void Setup(RenderTargetHandle source, RenderTargetHandle destination)
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
