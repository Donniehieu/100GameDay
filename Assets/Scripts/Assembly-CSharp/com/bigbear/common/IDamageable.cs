using UnityEngine;

namespace com.bigbear.common
{
	public interface IDamageable
	{
		void TakeDamage(float damage, IDamageDealer _damageDealer);

		void PlayTakeDamageEffect(IDamageDealer damageDealer);

		Transform TargetPoint();

		Collider GetCollider();

		Vector3 GetAttackOffset();

		Vector3 GetPointAttack(Vector3 position);
	}
}
