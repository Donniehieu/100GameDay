using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	[Serializable]
	public class Color32Transitions : TransitionStateCollection<Color32>
	{
		[Serializable]
		public class Color32TransitionState : TransitionState
		{
			public Color32TransitionState(string name, Color32 stateObject)
			{
				((TransitionStateCollection<>.TransitionState)(object)this)._002Ector((string)null, (T)default(_00210));
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetTransitionStates_003Ed__12 : IEnumerable<TransitionState>, IEnumerable, IEnumerator<TransitionState>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private TransitionState _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Color32Transitions _003C_003E4__this;

			private List<Color32TransitionState>.Enumerator _003C_003E7__wrap1;

			private TransitionState System_002ECollections_002EGeneric_002EIEnumerator_003CTheraBytes_002EBetterUi_002ETransitionStateCollection_003CUnityEngine_002EColor32_003E_002ETransitionState_003E_002ECurrent
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
			public _003CGetTransitionStates_003Ed__12(int _003C_003E1__state)
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
			private IEnumerator<TransitionState> System_002ECollections_002EGeneric_002EIEnumerable_003CTheraBytes_002EBetterUi_002ETransitionStateCollection_003CUnityEngine_002EColor32_003E_002ETransitionState_003E_002EGetEnumerator()
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
		private Graphic target;

		[SerializeField]
		private float fadeDuration;

		[SerializeField]
		private List<Color32TransitionState> states;

		public override UnityEngine.Object Target => null;

		public float FadeDurtaion
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color32Transitions(params string[] stateNames)
		{
			((TransitionStateCollection<>)(object)this)._002Ector((string[])null);
		}

		protected override void ApplyState(TransitionState state, bool instant)
		{
		}

		internal override void AddStateObject(string stateName)
		{
		}

		[IteratorStateMachine(typeof(_003CGetTransitionStates_003Ed__12))]
		protected override IEnumerable<TransitionState> GetTransitionStates()
		{
			return null;
		}

		internal override void SortStates(string[] sortedOrder)
		{
		}
	}
}
