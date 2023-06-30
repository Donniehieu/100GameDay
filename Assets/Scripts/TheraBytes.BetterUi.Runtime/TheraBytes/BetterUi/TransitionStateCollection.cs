using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	public abstract class TransitionStateCollection<T> : TransitionStateCollection
	{
		[Serializable]
		public abstract class TransitionState : TransitionStateBase
		{
			public T StateObject;

			public TransitionState(string name, T stateObject)
				: base(null)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetStates_003Ed__2 : IEnumerable<TransitionState>, IEnumerable, IEnumerator<TransitionState>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private TransitionState _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public TransitionStateCollection<T> _003C_003E4__this;

			private IEnumerator<TransitionState> _003C_003E7__wrap1;

			private TransitionState System_002ECollections_002EGeneric_002EIEnumerator_003CTheraBytes_002EBetterUi_002ETransitionStateCollection_003CT_003E_002ETransitionState_003E_002ECurrent
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
			public _003CGetStates_003Ed__2(int _003C_003E1__state)
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
			private IEnumerator<TransitionState> System_002ECollections_002EGeneric_002EIEnumerable_003CTheraBytes_002EBetterUi_002ETransitionStateCollection_003CT_003E_002ETransitionState_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		protected TransitionStateCollection(string[] stateNames)
		{
		}

		[IteratorStateMachine(typeof(TransitionStateCollection<>._003CGetStates_003Ed__2))]
		public IEnumerable<TransitionState> GetStates()
		{
			return null;
		}

		public override void Apply(string stateName, bool instant)
		{
		}

		protected abstract IEnumerable<TransitionState> GetTransitionStates();

		protected abstract void ApplyState(TransitionState state, bool instant);

		internal abstract void AddStateObject(string stateName);
	}
	[Serializable]
	public abstract class TransitionStateCollection
	{
		[Serializable]
		public abstract class TransitionStateBase
		{
			public string Name;

			public TransitionStateBase(string name)
			{
			}
		}

		public abstract UnityEngine.Object Target { get; }

		public abstract void Apply(string stateName, bool instant);

		internal abstract void SortStates(string[] sortedOrder);

		protected void SortStatesLogic<T>(List<T> states, string[] sortedOrder) where T : TransitionStateBase
		{
		}
	}
}
