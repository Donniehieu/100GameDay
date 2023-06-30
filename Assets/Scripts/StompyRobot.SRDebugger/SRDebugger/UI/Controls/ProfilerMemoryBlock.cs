using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SRF;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class ProfilerMemoryBlock : SRMonoBehaviourEx
	{
		[CompilerGenerated]
		private sealed class _003CCleanUp_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ProfilerMemoryBlock _003C_003E4__this;

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
			public _003CCleanUp_003Ed__8(int _003C_003E1__state)
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

		private float _lastRefresh;

		[RequiredField]
		public Text CurrentUsedText;

		[RequiredField]
		public Slider Slider;

		[RequiredField]
		public Text TotalAllocatedText;

		protected override void OnEnable()
		{
		}

		protected override void Update()
		{
		}

		public void TriggerRefresh()
		{
		}

		public void TriggerCleanup()
		{
		}

		[IteratorStateMachine(typeof(_003CCleanUp_003Ed__8))]
		private IEnumerator CleanUp()
		{
			return null;
		}
	}
}
