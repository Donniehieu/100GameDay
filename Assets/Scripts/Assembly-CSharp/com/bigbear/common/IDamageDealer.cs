using UnityEngine;

namespace com.bigbear.common
{
	public interface IDamageDealer
	{
		void CauseDamage();

		void SpawnProjectile();

		IAttackTarget GetTarget();

		AttackType GetAttackType();

		DamageType GetDamageType();

		float GetAoeRange();

		float GetAttackRange();

		Transform GetTransform();
	}
}
