using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	[Serializable]
	public class Vector2SizeModifier : ScreenDependentSize<Vector2>
	{
		[CompilerGenerated]
		private sealed class _003CGetModifiers_003Ed__3 : IEnumerable<SizeModifierCollection>, IEnumerable, IEnumerator<SizeModifierCollection>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private SizeModifierCollection _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Vector2SizeModifier _003C_003E4__this;

			private SizeModifierCollection System_002ECollections_002EGeneric_002EIEnumerator_003CTheraBytes_002EBetterUi_002ESizeModifierCollection_003E_002ECurrent
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
			public _003CGetModifiers_003Ed__3(int _003C_003E1__state)
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

			[DebuggerHidden]
			private IEnumerator<SizeModifierCollection> System_002ECollections_002EGeneric_002EIEnumerable_003CTheraBytes_002EBetterUi_002ESizeModifierCollection_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		public SizeModifierCollection ModX;

		public SizeModifierCollection ModY;

		public Vector2SizeModifier(Vector2 optimizedSize, Vector2 minSize, Vector2 maxSize)
		{
			((ScreenDependentSize<>)(object)this)._002Ector((T)default(_00210), (T)default(_00210), (T)default(_00210), (T)default(_00210));
		}

		[IteratorStateMachine(typeof(_003CGetModifiers_003Ed__3))]
		public override IEnumerable<SizeModifierCollection> GetModifiers()
		{
			return null;
		}

		protected override void AdjustSize(float factor, SizeModifierCollection mod, int index)
		{
		}

		protected override void CalculateOptimizedSize(Vector2 baseValue, float factor, SizeModifierCollection mod, int index)
		{
		}
	}
}
