using System.Collections.Generic;
using UnityEngine;

namespace MeshCombineStudio
{
	public class RemoveGeometryBelowTerrain : MonoBehaviour
	{
		private int totalTriangles;

		private int removeTriangles;

		private int skippedObjects;

		public List<Transform> terrains;

		public List<Transform> meshTerrains;

		public Bounds[] terrainBounds;

		public Bounds[] meshBounds;

		private Terrain[] terrainComponents;

		private Terrain[] terrainArray;

		private Bounds[] terrainBoundsArray;

		private MeshRenderer[] mrs;

		private Mesh[] meshTerrainComponents;

		private Mesh[] meshArray;

		public bool runOnStart;

		private void Start()
		{
		}

		public void Remove(GameObject go)
		{
		}

		public void RemoveMesh(Transform t, Mesh mesh)
		{
		}

		public bool IsMeshUnderTerrain(Transform t, Mesh mesh)
		{
			return false;
		}

		public void GetTerrainComponents()
		{
		}

		public void GetMeshRenderersAndComponents()
		{
		}

		public void CreateTerrainBounds()
		{
		}

		public void MakeIntersectLists(Bounds bounds)
		{
		}

		public int InterectTerrain(Vector3 pos)
		{
			return 0;
		}

		public int InterectMesh(Vector3 pos)
		{
			return 0;
		}

		public float GetTerrainHeight(Vector3 pos)
		{
			return 0f;
		}

		public void RemoveTriangles(Transform t, List<int> newTriangles, Vector3[] vertices)
		{
		}
	}
}
