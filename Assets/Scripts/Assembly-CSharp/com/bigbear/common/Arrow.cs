using UnityEngine;

namespace com.bigbear.common
{
	public class Arrow : Projectile
	{
		[SerializeField]
		private float maxXZSpeed;

		[SerializeField]
		private Vector3 gravity;

		private Transform targetTrans;

		private IDamageDealer sourceSolder;

		private Vector3 lastPosTarget;

		[SerializeField]
		private GameObject[] Levels;

		public bool MoveFree;

		public ParticleSystem eff;

		public TrailRenderer effTrail;

		public void SetLevel(int level)
		{
		}

		public override int GetId()
		{
			return 0;
		}

		public override void SetInfo(IDamageDealer _sourceSolder, IAttackTarget _targetSoldier, Vector3 _startPos, float _damage, string _targetTag, int _enemyMask, int level = 1)
		{
		}

		private void GetVelocity()
		{
		}

		protected override void UpdatePositionPerFrame(float dt)
		{
		}

		protected override void SelfDestroy()
		{
		}
	}
}
