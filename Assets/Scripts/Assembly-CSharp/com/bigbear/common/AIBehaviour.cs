using System;
using BigBear.Core.Runtime.FSM;

namespace com.bigbear.common
{
	public abstract class AIBehaviour : IDisposable
	{
		protected Hero aiController;

		protected FSM fsm;

		protected bool isCalculating;

		public AIBehaviour(Hero aiController)
		{
		}

		public void Init()
		{
		}

		public void Update(float dt)
		{
		}

		public AiState GetCurrentState()
		{
			return default(AiState);
		}

		protected abstract void InitFSM();

		public abstract void ChangeState(AiState newState);

		public virtual void StartCalculating()
		{
		}

		public virtual void Stop()
		{
		}

		public virtual void Pause(bool isPause)
		{
		}

		public virtual void Dispose()
		{
		}
	}
}
