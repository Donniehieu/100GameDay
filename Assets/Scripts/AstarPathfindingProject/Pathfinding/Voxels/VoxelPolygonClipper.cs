using System.Reflection;

namespace Pathfinding.Voxels
{
	[DefaultMember("Item")]
	internal struct VoxelPolygonClipper
	{
		public float[] x;

		public float[] y;

		public float[] z;

		public int n;

		public int Item
		{
			set
			{
			}
		}

		public VoxelPolygonClipper(int capacity)
		{
		}

		public void ClipPolygonAlongX(ref VoxelPolygonClipper result, float multi, float offset)
		{
		}

		public void ClipPolygonAlongZWithYZ(ref VoxelPolygonClipper result, float multi, float offset)
		{
		}

		public void ClipPolygonAlongZWithY(ref VoxelPolygonClipper result, float multi, float offset)
		{
		}
	}
}
