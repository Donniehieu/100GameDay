using UnityEngine;

namespace MeshCombineStudio
{
	[ExecuteInEditMode]
	public class LightmapSettings : MonoBehaviour
	{
		public MeshRenderer mr;

		public int lightmapIndex;

		public bool setLightmapScaleOffset;

		public Vector4 lightmapScaleOffset;

		private void OnEnable()
		{
		}
	}
}
