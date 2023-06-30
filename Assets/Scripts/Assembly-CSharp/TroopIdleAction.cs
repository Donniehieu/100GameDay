using BigBear.Core.Runtime.FSM;
using com.bigbear.common;

public class TroopIdleAction : FSMAction
{
	protected Troop hero;

	protected AIBehaviour aiBehaviour;

	private const float IntervalTime = 2f;

	private float deltaTime;

	public TroopIdleAction(FSMState owner, Troop hero, AIBehaviour aiBehaviour)
		: base(null)
	{
	}

	public override void OnEnter()
	{
	}

	public override void OnUpdate(float dt)
	{
	}
}
