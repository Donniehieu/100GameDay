using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	internal class DecalScreenSpaceRenderPass : ScriptableRenderPass
	{
		private FilteringSettings m_FilteringSettings;

		private ProfilingSampler m_ProfilingSampler;

		private List<ShaderTagId> m_ShaderTagIdList;

		private DecalDrawScreenSpaceSystem m_DrawSystem;

		private DecalScreenSpaceSettings m_Settings;

		public DecalScreenSpaceRenderPass(DecalScreenSpaceSettings settings, DecalDrawScreenSpaceSystem drawSystem)
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
