using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BigBear.Core.Runtime.TickManager;
using UnityEngine;

namespace com.bigbear.common
{
	public class Projectile : TickableBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CIeSelfDestroy_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Projectile _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CIeSelfDestroy_003Ed__29(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[SerializeField]
		protected ProjectileType projectileType;

		protected Vector3 Distance;

		protected float Duration;

		protected DateTime TimeStart;

		protected Vector3 StartPos;

		protected Vector3 TargetPos;

		public string Log;

		[SerializeField]
		protected float liveTimeMax;

		protected string targetTag;

		protected float livingTime;

		protected bool isFlying;

		protected Vector3 curVelocity;

		protected float damage;

		protected IDamageDealer damDealer;

		protected IAttackTarget TargetSoldier;

		public int enemyMask;

		protected string destroyReason;

		public override int GetId()
		{
			return 0;
		}

		public override void OnTickableEnabled()
		{
		}

		public override void OnTickableDisabled()
		{
		}

		public virtual void SetInfo(IDamageDealer _sourceSolder, IAttackTarget targetSoldier, Vector3 startPos, float _damage, string _targetTag, int _enemyMask, int level = 1)
		{
		}

		public override void OnTickableUpdated(float dt)
		{
		}

		protected virtual void UpdatePositionPerFrame(float dt)
		{
		}

		protected void CheckSelfDestroy()
		{
		}

		public virtual void SetPosition()
		{
		}

		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		protected virtual void OnTriggerExit(Collider other)
		{
		}

		private bool CheckTriggerAttack(Component other)
		{
			return false;
		}

		public virtual void CollideGround()
		{
		}

		[IteratorStateMachine(typeof(_003CIeSelfDestroy_003Ed__29))]
		protected IEnumerator IeSelfDestroy()
		{
			return null;
		}

		protected virtual void SelfDestroy()
		{
		}

		public virtual void SetSize(bool isBoss)
		{
		}
	}
}
