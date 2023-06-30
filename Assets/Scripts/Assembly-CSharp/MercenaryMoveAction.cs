using BigBear.Core.Runtime.FSM;
using UnityEngine;
using com.bigbear.common;

public class MercenaryMoveAction : FSMAction
{
	protected Mercenary hero;

	protected AIBehaviour aiBehaviour;

	protected Transform trnSoldier;

	protected Transform trnTarget;

	protected float range;

	private const float IntervalCheck = 1f;

	private float deltaTime;

	protected Collider[] results;

	private Vector3 target;

	public MercenaryMoveAction(FSMState owner, Mercenary hero, AIBehaviour aiBehaviour)
		: base(null)
	{
	}

	public override void OnEnter()
	{
	}

	public override void OnUpdate(float dt)
	{
	}

	public virtual void OnDestinationReached()
	{
	}

	public override void OnExit()
	{
	}
}
