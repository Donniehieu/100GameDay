using UnityEngine;

namespace MeshCombineStudio
{
	public class DisabledLodMeshRender : MonoBehaviour
	{
		[HideInInspector]
		public MeshCombiner meshCombiner;

		public CachedLodGameObject cachedLodGO;
	}
}
