using System;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal
{
	internal struct PostProcessPasses : IDisposable
	{
		private ColorGradingLutPass m_ColorGradingLutPass;

		private PostProcessPass m_PostProcessPass;

		private PostProcessPass m_FinalPostProcessPass;

		private RenderTargetHandle m_AfterPostProcessColor;

		private RenderTargetHandle m_ColorGradingLut;

		private PostProcessData m_RendererPostProcessData;

		private PostProcessData m_CurrentPostProcessData;

		private Material m_BlitMaterial;

		public ColorGradingLutPass colorGradingLutPass => null;

		public PostProcessPass postProcessPass => null;

		public PostProcessPass finalPostProcessPass => null;

		public RenderTargetHandle afterPostProcessColor => default(RenderTargetHandle);

		public RenderTargetHandle colorGradingLut => default(RenderTargetHandle);

		public bool isCreated => false;

		public PostProcessPasses(PostProcessData rendererPostProcessData, Material blitMaterial)
		{
		}

		public void Recreate(PostProcessData data)
		{
		}

		public void Dispose()
		{
		}
	}
}
