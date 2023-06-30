namespace UnityEngine.Rendering.Universal
{
	internal class PixelPerfectBackgroundPass : ScriptableRenderPass
	{
		private static readonly ProfilingSampler m_ProfilingScope;

		private bool m_SavedIsOrthographic;

		private float m_SavedOrthographicSize;

		public PixelPerfectBackgroundPass(RenderPassEvent evt)
		{
		}

		public void Setup(bool savedIsOrthographic, float savedOrthographicSize)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
}
