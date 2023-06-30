using BigBear.Core.Runtime.FSM;
using com.bigbear.common;

public class MercenaryIdleAction : FSMAction
{
	protected Mercenary hero;

	protected AIBehaviour aiBehaviour;

	private const float IntervalTime = 2f;

	private const float IntervalHp = 2f;

	private float deltaTime;

	private float deltaTimeHp;

	private bool isCanRestoneHp;

	public MercenaryIdleAction(FSMState owner, Mercenary hero, AIBehaviour aiBehaviour)
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
