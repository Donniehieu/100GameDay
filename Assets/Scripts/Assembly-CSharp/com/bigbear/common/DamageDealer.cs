using UnityEngine;

namespace com.bigbear.common
{
	public class DamageDealer : MonoBehaviour, IDamageDealer
	{
		protected Hero hero;

		public Hero HeroDealer => null;

		public void SetInfo()
		{
		}

		public void ResetInfo()
		{
		}

		public void Init()
		{
		}

		public virtual void CauseDamage()
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

		public virtual void SpawnProjectile()
		{
		}

		public void StartAttack()
		{
		}
	}
}
