using System;
using UnityEngine;

namespace MeshCombineStudio
{
	public class MeshCache
	{
		public class SubMeshCache
		{
			public Vector3[] vertices;

			public Vector3[] normals;

			public Vector4[] tangents;

			public Vector2[] uv;

			public Vector2[] uv2;

			public Vector2[] uv3;

			public Vector2[] uv4;

			public Color32[] colors32;

			public int[] triangles;

			public bool hasNormals;

			public bool hasTangents;

			public bool hasUv;

			public bool hasUv2;

			public bool hasUv3;

			public bool hasUv4;

			public bool hasColors;

			public int vertexCount;

			public int triangleCount;

			public SubMeshCache()
			{
			}

			public void CopySubMeshCache(SubMeshCache source)
			{
			}

			public void CopyArray<T>(Array sourceArray, ref T[] destinationArray, int vertexCount)
			{
			}

			public SubMeshCache(Mesh mesh, int subMeshIndex)
			{
			}

			public SubMeshCache(Mesh mesh, bool assignTriangles)
			{
			}

			public void CheckHasArrays()
			{
			}

			public void ResetHasBooleans()
			{
			}

			public void Init(bool initTriangles = true)
			{
			}

			public void RebuildVertexBuffer(SubMeshCache sub, bool resizeArrays)
			{
			}
		}

		public Mesh mesh;

		public SubMeshCache[] subMeshCache;

		public int subMeshCount;

		public MeshCache(Mesh mesh)
		{
		}
	}
}
