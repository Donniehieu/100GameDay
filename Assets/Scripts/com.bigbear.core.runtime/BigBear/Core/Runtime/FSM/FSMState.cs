using System.Collections.Generic;

namespace BigBear.Core.Runtime.FSM
{
	public class FSMState
	{
		private readonly int id;

		private readonly FSM owner;

		private readonly Dictionary<int, FSMState> transitionMap;

		private List<FSMAction> actions;

		public FSMState(int id, FSM owner)
		{
		}

		public void AddTransition(int id, FSMState destinationState)
		{
		}

		public FSMState GetTransition(int eventId)
		{
			return null;
		}

		public void AddAction(FSMAction action)
		{
		}

		public List<FSMAction> GetActions()
		{
			return null;
		}

		public void SendEvent(int eventId)
		{
		}

		internal int GetId()
		{
			return 0;
		}
	}
}
