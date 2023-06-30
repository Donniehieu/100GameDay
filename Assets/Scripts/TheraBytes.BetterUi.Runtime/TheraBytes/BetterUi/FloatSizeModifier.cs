using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TheraBytes.BetterUi
{
	[Serializable]
	public class FloatSizeModifier : ScreenDependentSize<float>
	{
		[CompilerGenerated]
		private sealed class _003CGetModifiers_003Ed__2 : IEnumerable<SizeModifierCollection>, IEnumerable, IEnumerator<SizeModifierCollection>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private SizeModifierCollection _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public FloatSizeModifier _003C_003E4__this;

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
			public _003CGetModifiers_003Ed__2(int _003C_003E1__state)
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

		public SizeModifierCollection Mod;

		public FloatSizeModifier(float optimizedSize, float minSize, float maxSize)
		{
			((ScreenDependentSize<>)(object)this)._002Ector((T)default(_00210), (T)default(_00210), (T)default(_00210), (T)default(_00210));
		}

		[IteratorStateMachine(typeof(_003CGetModifiers_003Ed__2))]
		public override IEnumerable<SizeModifierCollection> GetModifiers()
		{
			return null;
		}

		protected override void AdjustSize(float factor, SizeModifierCollection mod, int index)
		{
		}

		protected override void CalculateOptimizedSize(float baseValue, float factor, SizeModifierCollection mod, int index)
		{
		}
	}
}
