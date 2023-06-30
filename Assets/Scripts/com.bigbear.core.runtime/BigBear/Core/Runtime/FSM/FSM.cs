using System.Collections.Generic;

namespace BigBear.Core.Runtime.FSM
{
	public class FSM
	{
		private delegate void StateActionProcessor(FSMAction action);

		private readonly string name;

		public FSMState currentState;

		public FSMState previousState;

		private readonly Dictionary<int, FSMState> stateMap;

		public string Name => null;

		private void ProcessStateAction(FSMState state, StateActionType actionType, float dt = 0f)
		{
		}

		public FSMState AddState(int name)
		{
			return null;
		}

		public FSM(string name)
		{
		}

		public void Start(int stateId)
		{
		}

		public void ChangeToState(FSMState state)
		{
		}

		public void EnterState(FSMState state)
		{
		}

		private void ExitState(FSMState state)
		{
		}

		public void Update(float dt)
		{
		}

		public void FixUpdate(float dt)
		{
		}

		public void Destroy()
		{
		}

		public void SendEvent(int eventId)
		{
		}

		public int GetCurrentState()
		{
			return 0;
		}

		public int GetPreviousState()
		{
			return 0;
		}

		private FSMState ResolveTransition(int eventId)
		{
			return null;
		}
	}
}
