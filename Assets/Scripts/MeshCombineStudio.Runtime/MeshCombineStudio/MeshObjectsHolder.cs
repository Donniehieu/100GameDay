using System;
using UnityEngine;

namespace MeshCombineStudio
{
	[Serializable]
	public class MeshObjectsHolder
	{
		public FastList<MeshObject> meshObjects;

		public ObjectOctree.LODParent lodParent;

		public FastList<CachedGameObject> newCachedGOs;

		public int lodLevel;

		public Material mat;

		public bool hasChanged;

		public CombineCondition combineCondition;

		public MeshObjectsHolder(ref CombineCondition combineCondition, Material mat)
		{
		}
	}
}
