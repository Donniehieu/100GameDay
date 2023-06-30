using BigBear.Core.Runtime.FSM;
using com.bigbear.common;

public class MercenaryAttackAction : FSMAction
{
	protected Mercenary hero;

	protected AIBehaviour aiBehaviour;

	protected float attackTime;

	private const float IntervalCheckGuardRange = 1f;

	private float deltaTimeCheckGuardRange;

	public MercenaryAttackAction(FSMState owner, Mercenary hero, AIBehaviour aiBehaviour)
		: base(null)
	{
	}

	public override void OnEnter()
	{
	}

	private void CheckGuardRange()
	{
	}

	public override void OnUpdate(float dt)
	{
	}

	public virtual void Attack()
	{
	}
}
