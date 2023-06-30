using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	[Serializable]
	public class AnimationTransitions : TransitionStateCollection<string>
	{
		[Serializable]
		public class AnimationTransitionState : TransitionState
		{
			public AnimationTransitionState(string name, string stateObject)
			{
				((TransitionStateCollection<>.TransitionState)(object)this)._002Ector((string)null, (T)default(_00210));
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetTransitionStates_003Ed__8 : IEnumerable<TransitionState>, IEnumerable, IEnumerator<TransitionState>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private TransitionState _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public AnimationTransitions _003C_003E4__this;

			private List<AnimationTransitionState>.Enumerator _003C_003E7__wrap1;

			private TransitionState System_002ECollections_002EGeneric_002EIEnumerator_003CTheraBytes_002EBetterUi_002ETransitionStateCollection_003CSystem_002EString_003E_002ETransitionState_003E_002ECurrent
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
			public _003CGetTransitionStates_003Ed__8(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<TransitionState> System_002ECollections_002EGeneric_002EIEnumerable_003CTheraBytes_002EBetterUi_002ETransitionStateCollection_003CSystem_002EString_003E_002ETransitionState_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[SerializeField]
		private Animator target;

		[SerializeField]
		private List<AnimationTransitionState> states;

		public override UnityEngine.Object Target => null;

		public AnimationTransitions(params string[] stateNames)
		{
			((TransitionStateCollection<>)(object)this)._002Ector((string[])null);
		}

		protected override void ApplyState(TransitionState state, bool instant)
		{
		}

		internal override void AddStateObject(string stateName)
		{
		}

		[IteratorStateMachine(typeof(_003CGetTransitionStates_003Ed__8))]
		protected override IEnumerable<TransitionState> GetTransitionStates()
		{
			return null;
		}

		internal override void SortStates(string[] sortedOrder)
		{
		}
	}
}
