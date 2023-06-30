using UnityEngine;
using UnityEngine.Events;

namespace com.bigbear.common
{
	public class HeroAction : MonoBehaviour
	{
		protected Hero hero;

		[SerializeField]
		public Animator animator;

		[SerializeField]
		protected PathFinder pathFinder;

		public float AttackIntervalTime;

		public float AttackIntervalCurrent;

		protected float attackAnimLength;

		public bool isOnDestination;

		public UnityAction onDestinationAction;

		protected float normalAttackLength;

		[SerializeField]
		protected float moveAnimBaseSpeed;

		public int IndexAtk;

		public float speedcurrent;

		public float AttackAnimLength => 0f;

		public void Init()
		{
		}

		private void OnTargetReached()
		{
		}

		public virtual void SetInfo()
		{
		}

		public virtual void ResetInfo()
		{
		}

		protected void RefreshAnimationParam()
		{
		}

		protected virtual void GetAttackAnimLength()
		{
		}

		protected virtual void SetAttackType()
		{
		}

		public virtual void SetIdle()
		{
		}

		public virtual void MoveTo(Vector3 destination)
		{
		}

		public void ChangeMoveSpeed(float value)
		{
		}

		public void ChangeAttackSpeed(float value)
		{
		}

		public virtual void UpdatePosDestination(Vector3 destination)
		{
		}

		public void SetCanMove(bool canMove)
		{
		}

		public virtual void SetMove(bool isMove)
		{
		}

		public virtual void SetMove(bool isMove, float speed)
		{
		}

		public virtual void SetAttack(float speed)
		{
		}

		public virtual void SetAttack()
		{
		}

		public virtual void SetDie()
		{
		}

		public virtual void SetImpact()
		{
		}

		public virtual void SetJump()
		{
		}

		public virtual void SetLanding()
		{
		}

		public virtual void SetFalling()
		{
		}

		public void SetMoveSpeed(float moveSpeed)
		{
		}

		public void SetAttackSpeed(float attackSpeed)
		{
		}

		public void LookAt(Transform target)
		{
		}

		public void SetNoneGravity()
		{
		}
	}
}
