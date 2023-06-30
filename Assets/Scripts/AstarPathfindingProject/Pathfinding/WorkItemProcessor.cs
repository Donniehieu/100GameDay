using System.Reflection;
using System.Runtime.CompilerServices;

namespace Pathfinding
{
	internal class WorkItemProcessor : IWorkItemContext
	{
		[DefaultMember("Item")]
		private class IndexedQueue<T>
		{
			private T[] buffer;

			private int start;

			public T Item
			{
				get
				{
					return default(T);
				}
				set
				{
				}
			}

			public int Count
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public void Enqueue(T item)
			{
			}

			public T Dequeue()
			{
				return default(T);
			}
		}

		private readonly AstarPath astar;

		private readonly IndexedQueue<AstarWorkItem> workItems;

		private bool queuedWorkItemFloodFill;

		private bool anyGraphsDirty;

		public bool workItemsInProgressRightNow
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool anyQueued => false;

		public bool workItemsInProgress
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Pathfinding_002EIWorkItemContext_002EQueueFloodFill()
		{
		}

		private void Pathfinding_002EIWorkItemContext_002ESetGraphDirty(NavGraph graph)
		{
		}

		public void EnsureValidFloodFill()
		{
		}

		public WorkItemProcessor(AstarPath astar)
		{
		}

		public void OnFloodFill()
		{
		}

		public void AddWorkItem(AstarWorkItem item)
		{
		}

		public bool ProcessWorkItems(bool force)
		{
			return false;
		}
	}
}
