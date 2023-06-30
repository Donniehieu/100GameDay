using System;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.EnhancedTouch
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.4/manual/Touch.html#touch-simulation")]
	[ExecuteInEditMode]
	[AddComponentMenu("Input/Debug/Touch Simulation")]
	public class TouchSimulation : MonoBehaviour, IInputStateChangeMonitor
	{
		[NonSerialized]
		private int m_NumPointers;

		[NonSerialized]
		private Pointer[] m_Pointers;

		[NonSerialized]
		private Vector2[] m_CurrentPositions;

		[NonSerialized]
		private ButtonControl[] m_Touches;

		[NonSerialized]
		private int m_LastTouchId;

		[NonSerialized]
		private int m_PrimaryTouchIndex;

		[NonSerialized]
		private Action<InputDevice, InputDeviceChange> m_OnDeviceChange;

		[NonSerialized]
		private Action<InputEventPtr, InputDevice> m_OnEvent;

		internal static TouchSimulation s_Instance;

		public Touchscreen simulatedTouchscreen
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static TouchSimulation instance => null;

		public static void Enable()
		{
		}

		public static void Disable()
		{
		}

		public static void Destroy()
		{
		}

		protected void AddPointer(Pointer pointer)
		{
		}

		protected void RemovePointer(Pointer pointer)
		{
		}

		private void OnEvent(InputEventPtr eventPtr, InputDevice device)
		{
		}

		private void OnDeviceChange(InputDevice device, InputDeviceChange change)
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		private void UpdateTouch(int touchIndex, int pointerIndex, TouchPhase phase, InputEventPtr eventPtr = default(InputEventPtr))
		{
		}

		private void UnityEngine_002EInputSystem_002ELowLevel_002EIInputStateChangeMonitor_002ENotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex)
		{
		}

		private void UnityEngine_002EInputSystem_002ELowLevel_002EIInputStateChangeMonitor_002ENotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex)
		{
		}

		protected void InstallStateChangeMonitors(int startIndex = 0)
		{
		}

		protected void OnSourceControlChangedValue(InputControl control, double time, InputEventPtr eventPtr, long sourceDeviceAndButtonIndex)
		{
		}

		protected void UninstallStateChangeMonitors(int startIndex = 0)
		{
		}
	}
}
