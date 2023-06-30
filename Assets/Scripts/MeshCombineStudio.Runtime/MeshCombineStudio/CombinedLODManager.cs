using System;
using System.Collections.Generic;
using UnityEngine;

namespace MeshCombineStudio
{
	public class CombinedLODManager : MonoBehaviour
	{
		public enum LodMode
		{
			Automatic = 0,
			DebugLod = 1
		}

		public enum LodDistanceMode
		{
			Automatic = 0,
			Manual = 1
		}

		[Serializable]
		public class LOD
		{
			public Transform searchParent;

			public Sphere3 sphere;

			public LOD()
			{
			}

			public LOD(Transform searchParent)
			{
			}
		}

		public class Cell : BaseOctree.Cell
		{
			public Cell[] cells;

			private AABB3 box;

			public Cell()
			{
			}

			public Cell(Vector3 position, Vector3 size, int maxLevels)
			{
			}

			public void AddMeshRenderer(MeshRenderer mr, Vector3 position, int lodLevel, int lodLevels)
			{
			}

			private void AddMeshRendererInternal(MeshRenderer mr, Vector3 position, int lodLevel, int lodLevels)
			{
			}

			public void AutoLodInternal(LOD[] lods, float lodCulledDistance)
			{
			}

			public void LodInternal(LOD[] lods, int lodLevel)
			{
			}

			public void DrawGizmos(LOD[] lods)
			{
			}

			public void DrawGizmosInternal()
			{
			}
		}

		public class MaxCell : Cell
		{
			public List<MeshRenderer>[] mrList;

			public int currentLod;
		}

		public bool drawGizmos;

		public LOD[] lods;

		public float[] distances;

		public LodDistanceMode lodDistanceMode;

		public LodMode lodMode;

		public int showLod;

		public bool lodCulled;

		public float lodCullDistance;

		public Vector3 octreeCenter;

		public Vector3 octreeSize;

		public int maxLevels;

		public bool search;

		private Cell octree;

		private Transform cameraMainT;

		private void Awake()
		{
		}

		private void InitOctree()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void UpdateLods(MeshCombiner meshCombiner, int lodAmount)
		{
		}

		public void UpdateDistances(MeshCombiner meshCombiner)
		{
		}

		public void Search()
		{
		}

		public void ResetOctree()
		{
		}

		public void Lod(LodMode lodMode)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
