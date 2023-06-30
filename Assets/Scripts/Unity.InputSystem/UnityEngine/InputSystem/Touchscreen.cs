using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	[InputControlLayout(stateType = typeof(TouchscreenState), isGenericTypeOfDevice = true)]
	public class Touchscreen : Pointer, IInputStateCallbackReceiver, IEventMerger, ICustomDeviceReset
	{
		internal static float s_TapTime;

		internal static float s_TapDelayTime;

		internal static float s_TapRadiusSquared;

		public TouchControl primaryTouch
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public ReadOnlyArray<TouchControl> touches
		{
			[CompilerGenerated]
			get
			{
				return default(ReadOnlyArray<TouchControl>);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected TouchControl[] touchControlArray
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public new static Touchscreen current
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public override void MakeCurrent()
		{
		}

		protected override void OnRemoved()
		{
		}

		protected override void FinishSetup()
		{
		}

		protected new void OnNextUpdate()
		{
		}

		protected new void OnStateEvent(InputEventPtr eventPtr)
		{
		}

		private void UnityEngine_002EInputSystem_002ELowLevel_002EIInputStateCallbackReceiver_002EOnNextUpdate()
		{
		}

		private void UnityEngine_002EInputSystem_002ELowLevel_002EIInputStateCallbackReceiver_002EOnStateEvent(InputEventPtr eventPtr)
		{
		}

		private bool UnityEngine_002EInputSystem_002ELowLevel_002EIInputStateCallbackReceiver_002EGetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset)
		{
			return false;
		}

		private void UnityEngine_002EInputSystem_002ELowLevel_002EICustomDeviceReset_002EReset()
		{
		}

		internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
		{
			return false;
		}

		private bool UnityEngine_002EInputSystem_002ELowLevel_002EIEventMerger_002EMergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
		{
			return false;
		}

		private static void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr)
		{
		}
	}
}
