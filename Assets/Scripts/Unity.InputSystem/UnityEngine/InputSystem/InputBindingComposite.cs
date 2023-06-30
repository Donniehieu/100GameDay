using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	public abstract class InputBindingComposite
	{
		[CompilerGenerated]
		private sealed class _003CGetPartNames_003Ed__12 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private string _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private string composite;

			public string _003C_003E3__composite;

			private FieldInfo[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent
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
			public _003CGetPartNames_003Ed__12(int _003C_003E1__state)
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
			private IEnumerator<string> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EString_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		internal static TypeTable s_Composites;

		public abstract Type valueType { get; }

		public abstract int valueSizeInBytes { get; }

		public unsafe abstract void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize);

		public abstract object ReadValueAsObject(ref InputBindingCompositeContext context);

		public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		protected virtual void FinishSetup(ref InputBindingCompositeContext context)
		{
		}

		internal void CallFinishSetup(ref InputBindingCompositeContext context)
		{
		}

		internal static Type GetValueType(string composite)
		{
			return null;
		}

		public static string GetExpectedControlLayoutName(string composite, string part)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetPartNames_003Ed__12))]
		internal static IEnumerable<string> GetPartNames(string composite)
		{
			return null;
		}

		internal static string GetDisplayFormatString(string composite)
		{
			return null;
		}
	}
	public abstract class InputBindingComposite<TValue> : InputBindingComposite where TValue : struct
	{
		public override Type valueType => null;

		public override int valueSizeInBytes => 0;

		public abstract TValue ReadValue(ref InputBindingCompositeContext context);

		public unsafe override void ReadValue(ref InputBindingCompositeContext context, void* buffer, int bufferSize)
		{
		}

		public override object ReadValueAsObject(ref InputBindingCompositeContext context)
		{
			return null;
		}
	}
}
