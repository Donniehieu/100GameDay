namespace Pathfinding.Voxels
{
	public struct LinkedVoxelSpan
	{
		public uint bottom;

		public uint top;

		public int next;

		public int area;

		public LinkedVoxelSpan(uint bottom, uint top, int area)
		{
		}

		public LinkedVoxelSpan(uint bottom, uint top, int area, int next)
		{
		}
	}
}
