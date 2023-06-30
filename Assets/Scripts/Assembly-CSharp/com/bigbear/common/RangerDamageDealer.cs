using UnityEngine;

namespace com.bigbear.common
{
	public class RangerDamageDealer : DamageDealer
	{
		[SerializeField]
		protected ProjectileType projectileType;

		[SerializeField]
		protected Transform projectilePoint;

		public Color color;

		public Transform ProjectilePoint => null;

		public override void SpawnProjectile()
		{
		}
	}
}
