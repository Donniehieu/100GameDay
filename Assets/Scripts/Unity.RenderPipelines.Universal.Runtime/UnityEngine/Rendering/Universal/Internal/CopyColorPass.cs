using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class CopyColorPass : ScriptableRenderPass
	{
		private int m_SampleOffsetShaderHandle;

		private Material m_SamplingMaterial;

		private Downsampling m_DownsamplingMethod;

		private Material m_CopyColorMaterial;

		private RenderTargetIdentifier source
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

		public CopyColorPass(RenderPassEvent evt, Material samplingMaterial, Material copyColorMaterial = null)
		{
		}

		public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination, Downsampling downsampling)
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
