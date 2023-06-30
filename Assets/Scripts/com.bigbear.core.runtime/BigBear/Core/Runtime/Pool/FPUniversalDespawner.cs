using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BigBear.Core.Runtime.Pool
{
	public class FPUniversalDespawner : MonoBehaviour, IFastPoolItem
	{
		[CompilerGenerated]
		private sealed class _003CDespawn_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float despawn_delay;

			public FPUniversalDespawner _003C_003E4__this;

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
			public _003CDespawn_003Ed__25(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCheckAlive_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FPUniversalDespawner _003C_003E4__this;

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
			public _003CCheckAlive_003Ed__26(int _003C_003E1__state)
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
		private int targetPoolID;

		[SerializeField]
		private bool despawnDelayed;

		[SerializeField]
		private float delay;

		[SerializeField]
		private bool despawnOnParticlesDead;

		[SerializeField]
		private bool resetParticleSystem;

		[SerializeField]
		private bool despawnOnAudioSourceStop;

		private bool needCheck;

		private AudioSource aSource;

		private ParticleSystem pSystem;

		public int TargetPoolID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool DespawnDelayed => false;

		public float Delay => 0f;

		public bool DespawnOnParticlesDead => false;

		public bool ResetParticleSystem => false;

		public bool DespawnOnAudioSourceStop => false;

		private void Start()
		{
		}

		public void OnFastInstantiate()
		{
		}

		public void OnFastDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CDespawn_003Ed__25))]
		private IEnumerator Despawn(float despawn_delay)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCheckAlive_003Ed__26))]
		private IEnumerator CheckAlive()
		{
			return null;
		}
	}
}
