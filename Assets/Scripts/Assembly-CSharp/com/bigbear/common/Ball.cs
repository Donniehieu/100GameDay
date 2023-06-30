using UnityEngine;

namespace com.bigbear.common
{
	public class Ball : Projectile
	{
		[SerializeField]
		private float maxXZSpeed;

		[SerializeField]
		private Vector3 gravity;

		private Transform targetTrans;

		private IDamageDealer sourceSolder;

		private Vector3 lastPosTarget;

		[SerializeField]
		private MeshRenderer meshRenderer;

		[SerializeField]
		public ParticleSystem eff;

		public override int GetId()
		{
			return 0;
		}

		public void SetColor(Color color)
		{
		}

		public override void SetInfo(IDamageDealer _sourceSolder, IAttackTarget _targetSoldier, Vector3 _startPos, float _damage, string _targetTag, int _enemyMask, int level)
		{
		}

		private void GetVelocity()
		{
		}

		protected override void UpdatePositionPerFrame(float dt)
		{
		}

		protected override void OnTriggerEnter(Collider other)
		{
		}
	}
}
