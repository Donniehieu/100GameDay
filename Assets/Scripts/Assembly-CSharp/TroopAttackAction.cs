using BigBear.Core.Runtime.FSM;
using com.bigbear.common;

public class TroopAttackAction : FSMAction
{
	protected Troop hero;

	protected AIBehaviour aiBehaviour;

	protected float attackTime;

	public TroopAttackAction(FSMState owner, Troop hero, AIBehaviour aiBehaviour)
		: base(null)
	{
	}

	public override void OnEnter()
	{
	}

	public override void OnUpdate(float dt)
	{
	}

	public virtual void Attack()
	{
	}
}
