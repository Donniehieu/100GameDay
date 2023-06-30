using UnityEngine;

namespace MVoxelizer
{
	public class MVGrid
	{
		public float unitSize;

		public MVInt3 unitCount;

		public Vector3 unitVoxelRatio;

		public Quaternion voxelRotation;

		public Vector3 origin;

		public MVInt3 GetGridCoordinate(Vector3 p)
		{
			return null;
		}

		public Vector3 GetPosition(MVInt3 coord)
		{
			return default(Vector3);
		}

		public Vector3 GetVertex(Vector3 v, Vector3 offset)
		{
			return default(Vector3);
		}

		public void Init(MeshVoxelizer voxelizer, MVSource source)
		{
		}
	}
}
