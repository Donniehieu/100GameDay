using System;
using UnityEngine;

namespace MeshCombineStudio
{
	[Serializable]
	public class CachedLodGameObject : CachedGameObject
	{
		public Vector3 center;

		public int lodCount;

		public int lodLevel;

		public CachedLodGameObject(CachedGameObject cachedGO, int lodCount, int lodLevel)
			: base(null, null, null, null, null, null)
		{
		}
	}
}
