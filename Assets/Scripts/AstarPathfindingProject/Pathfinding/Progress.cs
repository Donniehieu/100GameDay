namespace Pathfinding
{
	public struct Progress
	{
		public readonly float progress;

		public readonly string description;

		public Progress(float progress, string description)
		{
		}

		public Progress MapTo(float min, float max, string prefix = null)
		{
			return default(Progress);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
