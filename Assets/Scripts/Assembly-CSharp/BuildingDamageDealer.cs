using UnityEngine;
using com.bigbear.common;

public class BuildingDamageDealer : MonoBehaviour, IDamageDealer
{
	private BuildingBase BuildingBase;

	private IAttackTarget IAttackTarget;

	private void Start()
	{
	}

	public void CauseDamage()
	{
	}

	public void SpawnProjectile()
	{
	}

	public IAttackTarget GetTarget()
	{
		return null;
	}

	public AttackType GetAttackType()
	{
		return default(AttackType);
	}

	public DamageType GetDamageType()
	{
		return default(DamageType);
	}

	public float GetAoeRange()
	{
		return 0f;
	}

	public float GetAttackRange()
	{
		return 0f;
	}

	public Transform GetTransform()
	{
		return null;
	}
}
