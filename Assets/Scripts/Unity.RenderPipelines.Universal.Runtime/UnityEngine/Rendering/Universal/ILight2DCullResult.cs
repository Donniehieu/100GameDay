using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	internal interface ILight2DCullResult
	{
		List<Light2D> visibleLights { get; }

		LightStats GetLightStatsByLayer(int layer);

		bool IsSceneLit();
	}
}
