using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Voxelize : MonoBehaviour
{
	public class VoxelizedMesh
	{
		public byte[,,] volume;

		public Bounds bounds;

		public Int3 voxels;
	}

	public struct Int3
	{
		public int x;

		public int y;

		public int z;

		public Int3(int x, int y, int z)
		{
		}

		public static Int3 operator +(Int3 a, Int3 b)
		{
			return default(Int3);
		}

		public override string ToString()
		{
			return null;
		}
	}

	private static readonly byte[] bits;

	private static Dictionary<Mesh, VoxelizedMesh> voxelizedLookup;

	private static List<float> intersectList;

	private const byte insideVoxel = 1;

	private const byte outsideVoxel = 2;

	public int voxelizeLayer;

	public float voxelResolution;

	public bool voxelize;

	public void Update()
	{
	}

	private VoxelizedMesh VoxelizeMesh(Transform t, float voxelResolution, int voxelizeLayer)
	{
		return null;
	}

	private static string PrintVector3(Vector3 v)
	{
		return null;
	}

	private static void MultiCast(Ray ray, List<float> points, float hitOffset, float maxDistance, LayerMask voxelizeLayerMask)
	{
	}

	private static void Report(VoxelizedMesh vm, float voxelResolution)
	{
	}

	private void OnDrawGizmos()
	{
	}

	public void DrawVolume(Transform t, float voxelResolution)
	{
	}
}
