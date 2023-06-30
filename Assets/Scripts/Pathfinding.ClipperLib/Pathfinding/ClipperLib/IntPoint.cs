namespace Pathfinding.ClipperLib
{
	public struct IntPoint
	{
		public long X;

		public long Y;

		public IntPoint(long X, long Y)
		{
		}

		public IntPoint(double x, double y)
		{
		}

		public IntPoint(IntPoint pt)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(IntPoint a, IntPoint b)
		{
			return false;
		}

		public static bool operator !=(IntPoint a, IntPoint b)
		{
			return false;
		}
	}
}
