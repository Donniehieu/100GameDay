namespace BigBear.Core.Runtime.FSM
{
	public class FSMAction
	{
		private readonly FSMState owner;

		public FSMAction(FSMState owner)
		{
		}

		public FSMState GetOwner()
		{
			return null;
		}

		public virtual void OnEnter()
		{
		}

		public virtual void OnUpdate(float dt)
		{
		}

		public virtual void OnFixUpdate(float dt)
		{
		}

		public virtual void OnExit()
		{
		}

		public virtual void OnDestroy()
		{
		}
	}
}
