using BigBear.Core.Runtime.FSM;
using com.bigbear.common;

public class PlayerAttackAction : FSMAction
{
	protected PlayerController hero;

	protected AIBehaviour aiBehaviour;

	private const float IntervalCheck = 0.3f;

	protected float deltaTime;

	public PlayerAttackAction(FSMState owner, PlayerController hero, AIBehaviour aiBehaviour)
		: base(null)
	{
	}

	public override void OnEnter()
	{
	}

	public override void OnUpdate(float dt)
	{
	}

	public virtual void FindEnemy()
	{
	}
}
