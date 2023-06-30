using System.Collections.Generic;
using UnityEngine;

namespace MeshCombineStudio
{
	[ExecuteInEditMode]
	public class MeshCombinerData : MonoBehaviour
	{
		public Dictionary<Collider, CachedGameObject> colliderLookup;

		public Dictionary<LODGroup, CachedGameObject> lodGroupLookup;

		[HideInInspector]
		public List<GameObject> combinedGameObjects;

		[HideInInspector]
		public List<CachedGameObject> foundObjects;

		[HideInInspector]
		public List<CachedLodGameObject> foundLodObjects;

		[HideInInspector]
		public List<LODGroup> foundLodGroups;

		[HideInInspector]
		public List<Collider> foundColliders;

		private void OnValidate()
		{
		}

		private void OnEnable()
		{
		}

		public void ClearAll()
		{
		}
	}
}
