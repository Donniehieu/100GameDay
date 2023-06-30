namespace Pathfinding
{
	public struct Connection
	{
		public GraphNode node;

		public uint cost;

		public byte shapeEdge;

		public const byte NoSharedEdge = byte.MaxValue;

		public Connection(GraphNode node, uint cost, byte shapeEdge = byte.MaxValue)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
