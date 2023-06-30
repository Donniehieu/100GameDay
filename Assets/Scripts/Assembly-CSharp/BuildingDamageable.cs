using UnityEngine;
using com.bigbear.common;

public class BuildingDamageable : MonoBehaviour, IDamageable
{
	private BuildingBase BuildingBase;

	private BuildingAction BuildingAction;

	public Collider Collider;

	private void Start()
	{
	}

	private void OnValidate()
	{
	}

	public void TakeDamage(float damage, IDamageDealer _damageDealer)
	{
	}

	public void PlayTakeDamageEffect(IDamageDealer damageDealer)
	{
	}

	public Transform TargetPoint()
	{
		return null;
	}

	public Collider GetCollider()
	{
		return null;
	}

	public Vector3 GetAttackOffset()
	{
		return default(Vector3);
	}

	public Vector3 GetPointAttack(Vector3 position)
	{
		return default(Vector3);
	}
}
