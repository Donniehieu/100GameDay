using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Color Curves", new Type[] { typeof(UniversalRenderPipeline) })]
	public sealed class ColorCurves : VolumeComponent, IPostProcessComponent
	{
		public TextureCurveParameter master;

		public TextureCurveParameter red;

		public TextureCurveParameter green;

		public TextureCurveParameter blue;

		public TextureCurveParameter hueVsHue;

		public TextureCurveParameter hueVsSat;

		public TextureCurveParameter satVsSat;

		public TextureCurveParameter lumVsSat;

		public bool IsActive()
		{
			return false;
		}

		public bool IsTileCompatible()
		{
			return false;
		}
	}
}
