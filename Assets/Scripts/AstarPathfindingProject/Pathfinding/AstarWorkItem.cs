using System;

namespace Pathfinding
{
	public struct AstarWorkItem
	{
		public Action init;

		public Action<IWorkItemContext> initWithContext;

		public Func<bool, bool> update;

		public Func<IWorkItemContext, bool, bool> updateWithContext;

		public AstarWorkItem(Func<bool, bool> update)
		{
		}

		public AstarWorkItem(Func<IWorkItemContext, bool, bool> update)
		{
		}

		public AstarWorkItem(Action init, Func<bool, bool> update = null)
		{
		}

		public AstarWorkItem(Action<IWorkItemContext> init, Func<IWorkItemContext, bool, bool> update = null)
		{
		}
	}
}
