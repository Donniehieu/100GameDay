using UnityEngine;
using UnityEngine.Events;

namespace com.bigbear.common
{
	public class Damageable : MonoBehaviour, IDamageable
	{
		protected Hero hero;

		[SerializeField]
		protected Collider col;

		[SerializeField]
		protected Transform targetPoint;

		protected IDamageDealer damageDealer;

		public UnityEvent OnImpact;

		public Collider Collider => null;

		public Hero HeroDamageable => null;

		public void SetInfo()
		{
		}

		public void ResetInfo()
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

		public void SetStateCollider(bool state)
		{
		}

		public Vector3 GetAttackOffset()
		{
			return default(Vector3);
		}

		public virtual void TakeDamage(float damage, IDamageDealer _damageDealer)
		{
		}

		public virtual void PlayTakeDamageEffect(IDamageDealer damageDealer)
		{
		}

		public void Init()
		{
		}

		public Vector3 GetPointAttack(Vector3 position)
		{
			return default(Vector3);
		}
	}
}
