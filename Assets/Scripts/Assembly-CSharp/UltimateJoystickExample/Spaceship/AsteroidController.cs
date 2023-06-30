using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UltimateJoystickExample.Spaceship
{
	public class AsteroidController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayInitialDestruction_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delayTime;

			public AsteroidController _003C_003E4__this;

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
			public _003CDelayInitialDestruction_003Ed__6(int _003C_003E1__state)
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

		public GameManager asteroidManager;

		private Rigidbody myRigidbody;

		private bool canDestroy;

		private bool isDestroyed;

		public bool isDebris;

		public void Setup(Vector3 force, Vector3 torque)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayInitialDestruction_003Ed__6))]
		private IEnumerator DelayInitialDestruction(float delayTime)
		{
			return null;
		}

		private void Update()
		{
		}

		private void OnCollisionEnter(Collision theCollision)
		{
		}

		private void Explode()
		{
		}
	}
}
