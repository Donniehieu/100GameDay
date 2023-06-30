using UnityEngine;
using com.bigbear.common;

public class BuildingRange : BuildingBase
{
	[SerializeField]
	private Transform pointAttack;

	[SerializeField]
	private ProjectileType projectileType;

	private Vector3 origin;

	private Collider[] result;

	protected IAttackTarget IAttackTarget;

	protected IDamageDealer DamageDealer;

	private void Start()
	{
	}

	public override void Update()
	{
	}

	public void FindTarget()
	{
	}

	private void Attack()
	{
	}
}
