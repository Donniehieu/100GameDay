using UnityEngine;
using com.bigbear.common;

public class Enemy : Hero
{
	public EnemyUnitData UnitData;

	private Collider[] colliders;

	private int BuildingMask;

	public void SetInfo(EnemyUnitData data)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void CallbackHeroReviveEvent(HeroReviveEvent e)
	{
	}

	private void CallbackDestroyEvent(DestroyEvent e)
	{
	}

	public void FindBuildingMinDistance()
	{
	}

	public IAttackTarget FindTargetMinDistance()
	{
		return null;
	}

	public IAttackTarget FindTargetInRange(bool findBuilding = false)
	{
		return null;
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

	public override void OnDie()
	{
	}

	public void TakeImpact()
	{
	}
}
