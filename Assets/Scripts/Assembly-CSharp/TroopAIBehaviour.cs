using System.Runtime.CompilerServices;
using BigBear.Core.Runtime.FSM;
using com.bigbear.common;

public class TroopAIBehaviour : AIBehaviour
{
	protected FSMState idleState;

	protected FSMState attackState;

	protected FSMState moveState;

	private TroopIdleAction IdleAction;

	private TroopAttackAction AttackAction;

	private TroopMoveAction MoveAction;

	public AiState CurrentState
	{
		[CompilerGenerated]
		get
		{
			return default(AiState);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public TroopAIBehaviour(Troop aiController)
		: base(null)
	{
	}

	protected override void InitFSM()
	{
	}

	private void AddState()
	{
	}

	private void AddTransition()
	{
	}

	public override void ChangeState(AiState newState)
	{
	}

	public override void StartCalculating()
	{
	}

	public override void Dispose()
	{
	}
}
