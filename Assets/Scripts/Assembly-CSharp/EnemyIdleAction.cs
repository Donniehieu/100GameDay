using BigBear.Core.Runtime.FSM;
using com.bigbear.common;

public class EnemyIdleAction : FSMAction
{
	protected Enemy hero;

	protected AIBehaviour aiBehaviour;

	private const float IntervalTime = 0.2f;

	private float deltaTime;

	public EnemyIdleAction(FSMState owner, Enemy hero, AIBehaviour aiBehaviour)
		: base(null)
	{
	}

	public override void OnEnter()
	{
	}

	private void CheckFindTarget()
	{
	}

	public override void OnUpdate(float dt)
	{
	}
}
