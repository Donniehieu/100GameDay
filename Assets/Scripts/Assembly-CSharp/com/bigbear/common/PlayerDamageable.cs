using UnityEngine;

namespace com.bigbear.common
{
	public class PlayerDamageable : Damageable
	{
		[SerializeField]
		private Rigidbody rb;

		public override void TakeDamage(float damage, IDamageDealer _damageDealer)
		{
		}

		public void Revive()
		{
		}

		public override void PlayTakeDamageEffect(IDamageDealer damageDealer)
		{
		}
	}
}
