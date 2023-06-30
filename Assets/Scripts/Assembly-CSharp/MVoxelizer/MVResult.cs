using System.Collections.Generic;
using UnityEngine;

namespace MVoxelizer
{
	public class MVResult
	{
		public List<Vector3> vertices;

		public List<List<int>> triangles;

		public List<Vector3> normals;

		public List<Vector2> uv;

		public List<Vector2> uv2;

		public List<Vector2> uv3;

		public List<Vector2> uv4;

		public List<BoneWeight> boneWeights;

		public Mesh voxelizedMesh;

		public Material[] voxelizedMaterials;

		public MVGrid grid;

		public Mesh voxelMesh;

		public void Init(int subMeshCount)
		{
		}

		public void AddFaceVertices(MVVoxel voxel, int vIndex, int index)
		{
		}

		public void AddFaceUV(int v)
		{
		}
	}
}
