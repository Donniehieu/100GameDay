using UnityEngine;

namespace MVoxelizer
{
	public class MVSource
	{
		public Transform transform;

		public Mesh mesh;

		public Material[] materials;

		public MeshFilter meshFilter;

		public MeshRenderer meshRenderer;

		public SkinnedMeshRenderer skinnedMeshRenderer;

		public void Init(GameObject sourceGameObject)
		{
		}

		public Vector2 GetUVCoord(MVVoxel voxel)
		{
			return default(Vector2);
		}

		public Vector2 GetUV2Coord(MVVoxel voxel)
		{
			return default(Vector2);
		}

		public Vector2 GetUV3Coord(MVVoxel voxel)
		{
			return default(Vector2);
		}

		public Vector2 GetUV4Coord(MVVoxel voxel)
		{
			return default(Vector2);
		}
	}
}
