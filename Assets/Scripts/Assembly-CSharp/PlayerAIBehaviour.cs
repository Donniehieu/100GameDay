using System.Runtime.CompilerServices;
using BigBear.Core.Runtime.FSM;
using com.bigbear.common;

public class PlayerAIBehaviour : AIBehaviour
{
	protected FSMState attackState;

	private PlayerAttackAction AttackAction;

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

	public PlayerAIBehaviour(PlayerController aiController)
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
