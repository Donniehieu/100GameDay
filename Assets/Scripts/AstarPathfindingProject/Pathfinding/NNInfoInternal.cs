using UnityEngine;

namespace Pathfinding
{
	public struct NNInfoInternal
	{
		public GraphNode node;

		public GraphNode constrainedNode;

		public Vector3 clampedPosition;

		public Vector3 constClampedPosition;

		public NNInfoInternal(GraphNode node)
		{
		}

		public void UpdateInfo()
		{
		}
	}
}
