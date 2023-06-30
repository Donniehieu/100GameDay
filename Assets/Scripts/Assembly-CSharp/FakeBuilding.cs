using UnityEngine;
using com.bigbear.common;

public class FakeBuilding : MonoBehaviour, IAttackTarget, IDamageable
{
	public int Hp;

	public Collider Collider;

	private void OnValidate()
	{
	}

	public Vector3 GetAttackOffset()
	{
		return default(Vector3);
	}

	public Collider GetCollider()
	{
		return null;
	}

	public IDamageable GetDamageable()
	{
		return null;
	}

	public Transform GetTransform()
	{
		return null;
	}

	public bool IsDie()
	{
		return false;
	}

	public void PlayTakeDamageEffect(IDamageDealer damageDealer)
	{
	}

	public void TakeDamage(float damage, IDamageDealer _damageDealer)
	{
	}

	public Transform TargetPoint()
	{
		return null;
	}

	public Vector3 GetPointAttack(Vector3 position)
	{
		return default(Vector3);
	}

	public TargetType GetTargetType()
	{
		return default(TargetType);
	}
}
