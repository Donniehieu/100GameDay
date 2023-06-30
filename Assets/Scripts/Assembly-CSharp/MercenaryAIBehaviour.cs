using System.Runtime.CompilerServices;
using BigBear.Core.Runtime.FSM;
using com.bigbear.common;

public class MercenaryAIBehaviour : AIBehaviour
{
	protected FSMState idleState;

	protected FSMState attackState;

	protected FSMState moveState;

	private MercenaryIdleAction IdleAction;

	private MercenaryAttackAction AttackAction;

	private MercenaryMoveAction MoveAction;

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

	public MercenaryAIBehaviour(Mercenary aiController)
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
