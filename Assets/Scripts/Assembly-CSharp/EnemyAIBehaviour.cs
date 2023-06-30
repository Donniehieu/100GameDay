using System.Runtime.CompilerServices;
using BigBear.Core.Runtime.FSM;
using com.bigbear.common;

public class EnemyAIBehaviour : AIBehaviour
{
	protected FSMState idleState;

	protected FSMState attackState;

	protected FSMState moveState;

	private EnemyIdleAction IdleAction;

	private EnemyAttackAction AttackAction;

	private EnemyMoveAction MoveAction;

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

	public EnemyAIBehaviour(Enemy aiController)
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
