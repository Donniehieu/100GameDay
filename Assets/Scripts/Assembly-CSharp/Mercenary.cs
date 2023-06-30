using System.Collections.Generic;
using com.bigbear.common;

public class Mercenary : Hero
{
	public MercenaryUnitData UnitData;

	internal Hero player;

	private IEnumerable<IAttackTarget> queryFindTargetInRange;

	public float GuardRange => 0f;

	private void Start()
	{
	}

	public void SetInfo(MercenaryUnitData data)
	{
	}

	public void CheckAttackTarget()
	{
	}

	public void FindTargetInRange()
	{
	}

	public bool CheckInRange(IAttackTarget target)
	{
		return false;
	}

	public bool CheckInRange()
	{
		return false;
	}

	public bool CheckPlayerInGuardRange()
	{
		return false;
	}

	public override TargetType GetTargetType()
	{
		return default(TargetType);
	}

	public void RestoneHp(float dt)
	{
	}

	public override bool IsDie()
	{
		return false;
	}
}
