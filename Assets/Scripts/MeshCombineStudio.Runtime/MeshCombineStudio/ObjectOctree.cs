using System.Collections.Generic;
using UnityEngine;

namespace MeshCombineStudio
{
	public class ObjectOctree
	{
		public class LODParent
		{
			public GameObject cellGO;

			public Transform cellT;

			public LODGroup lodGroup;

			public LODLevel[] lodLevels;

			public bool hasChanged;

			public int jobsPending;

			public LODParent(int lodCount)
			{
			}

			public void AssignLODGroup(MeshCombiner meshCombiner)
			{
			}

			public void ApplyChanges(MeshCombiner meshCombiner)
			{
			}
		}

		public class LODLevel
		{
			public FastList<CachedGameObject> cachedGOs;

			public Dictionary<CombineCondition, MeshObjectsHolder> meshObjectsHoldersLookup;

			public FastList<MeshObjectsHolder> changedMeshObjectsHolders;

			public FastList<MeshRenderer> newMeshRenderers;

			public int vertCount;

			public int objectCount;

			public void ApplyChanges(MeshCombiner meshCombiner)
			{
			}
		}

		public class MaxCell : Cell
		{
			public static int maxCellCount;

			public LODParent[] lodParents;

			public List<LODParent> changedLodParents;

			public bool hasChanged;

			public void ApplyChanges(MeshCombiner meshCombiner)
			{
			}
		}

		public class Cell : BaseOctree.Cell
		{
			public Cell[] cells;

			public Cell()
			{
			}

			public Cell(Vector3 position, Vector3 size, int maxLevels)
			{
			}

			public MaxCell GetCell(Vector3 position)
			{
				return null;
			}

			private MaxCell GetCellInternal(Vector3 position)
			{
				return null;
			}

			public CachedGameObject AddObject(Vector3 position, MeshCombiner meshCombiner, CachedGameObject cachedGO, int lodParentIndex, int lodLevel, bool isChangeMode = false)
			{
				return null;
			}

			private void AddObjectInternal(MeshCombiner meshCombiner, CachedGameObject cachedGO, Vector3 position, int lodParentIndex, int lodLevel, bool isChangeMode)
			{
			}

			public void SortObjects(MeshCombiner meshCombiner)
			{
			}

			public bool SortObject(MeshCombiner meshCombiner, LODLevel lod, CachedGameObject cachedGO, bool isChangeMode = false)
			{
				return false;
			}

			public void CombineMeshes(MeshCombiner meshCombiner, int lodParentIndex)
			{
			}

			public void Draw(MeshCombiner meshCombiner, bool onlyMaxLevel, bool drawLevel0)
			{
			}
		}
	}
}
