using UnityEngine;

namespace MVoxelizer
{
	public class MVVoxel
	{
		public Vector3 centerPos;

		public Vector3 vertPos;

		public int index;

		public int subMesh;

		public Vector3 ratio;

		public int verticeCount;

		public int sampleCount;

		public MVVoxel v_forward;

		public MVVoxel v_up;

		public MVVoxel v_back;

		public MVVoxel v_down;

		public MVVoxel v_left;

		public MVVoxel v_right;

		public bool forward;

		public bool up;

		public bool back;

		public bool down;

		public bool left;

		public bool right;

		public void UpdateNormal(Vector3 normal)
		{
		}
	}
}
