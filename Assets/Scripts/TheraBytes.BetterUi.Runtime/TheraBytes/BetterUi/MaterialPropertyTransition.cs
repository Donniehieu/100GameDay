using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	[Serializable]
	public class MaterialPropertyTransition : TransitionStateCollection<float>
	{
		[Serializable]
		public class MaterialPropertyTransitionState : TransitionState
		{
			public MaterialPropertyTransitionState(string name, float stateObject)
			{
				((TransitionStateCollection<>.TransitionState)(object)this)._002Ector((string)null, (T)default(_00210));
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetTransitionStates_003Ed__18 : IEnumerable<TransitionState>, IEnumerable, IEnumerator<TransitionState>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private TransitionState _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public MaterialPropertyTransition _003C_003E4__this;

			private List<MaterialPropertyTransitionState>.Enumerator _003C_003E7__wrap1;

			private TransitionState System_002ECollections_002EGeneric_002EIEnumerator_003CTheraBytes_002EBetterUi_002ETransitionStateCollection_003CSystem_002ESingle_003E_002ETransitionState_003E_002ECurrent
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
			public _003CGetTransitionStates_003Ed__18(int _003C_003E1__state)
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
			private IEnumerator<TransitionState> System_002ECollections_002EGeneric_002EIEnumerable_003CTheraBytes_002EBetterUi_002ETransitionStateCollection_003CSystem_002ESingle_003E_002ETransitionState_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoCrossFadeProperty_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public float startValue;

			public float targetValue;

			public MaterialPropertyTransition _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

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
			public _003CCoCrossFadeProperty_003Ed__20(int _003C_003E1__state)
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

		private static Dictionary<MaterialPropertyTransition, Coroutine> activeCoroutines;

		private static List<MaterialPropertyTransition> keysToRemove;

		[SerializeField]
		private BetterImage target;

		[SerializeField]
		private float fadeDuration;

		[SerializeField]
		private List<MaterialPropertyTransitionState> states;

		[SerializeField]
		private int propertyIndex;

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

		public int PropertyIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public MaterialPropertyTransition(params string[] stateNames)
		{
			((TransitionStateCollection<>)(object)this)._002Ector((string[])null);
		}

		protected override void ApplyState(TransitionState state, bool instant)
		{
		}

		internal override void AddStateObject(string stateName)
		{
		}

		[IteratorStateMachine(typeof(_003CGetTransitionStates_003Ed__18))]
		protected override IEnumerable<TransitionState> GetTransitionStates()
		{
			return null;
		}

		private void CrossFadeProperty(float startValue, float targetValue, float duration)
		{
		}

		[IteratorStateMachine(typeof(_003CCoCrossFadeProperty_003Ed__20))]
		private IEnumerator CoCrossFadeProperty(float startValue, float targetValue, float duration)
		{
			return null;
		}

		internal override void SortStates(string[] sortedOrder)
		{
		}
	}
}
