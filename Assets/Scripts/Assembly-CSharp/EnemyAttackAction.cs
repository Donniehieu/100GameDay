using BigBear.Core.Runtime.FSM;
using com.bigbear.common;

public class EnemyAttackAction : FSMAction
{
	protected Enemy hero;

	protected AIBehaviour aiBehaviour;

	protected float attackTime;

	public EnemyAttackAction(FSMState owner, Enemy hero, AIBehaviour aiBehaviour)
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

	public void CheckAttackTarget()
	{
	}
}
