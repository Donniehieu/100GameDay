using System.Collections.Generic;
using com.bigbear.common;

public class Troop : Hero
{
	public TroopUnitData UnitData;

	private IEnumerable<IAttackTarget> queryFindTargetMinDistance;

	private IEnumerable<IAttackTarget> queryFindTargetInRange;

	public BuildingAction Building;

	private void Start()
	{
	}

	public void SetInfo(TroopUnitData data, BuildingAction building)
	{
	}

	public void CheckAttackTarget()
	{
	}

	public void FindBuildingMinDistance()
	{
	}

	public void FindTargetMinDistance()
	{
	}

	public void FindTargetInRange(bool findBuilding = false)
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
