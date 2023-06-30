using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.OnScreen;
using UnityEngine.UI;

[ExecuteInEditMode]
public class UltimateJoystick : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler
{
	public enum ScalingAxis
	{
		Width = 0,
		Height = 1
	}

	public enum Anchor
	{
		Left = 0,
		Right = 1
	}

	public enum Axis
	{
		Both = 0,
		X = 1,
		Y = 2
	}

	public enum Boundary
	{
		Circular = 0,
		Square = 1
	}

	public enum TapCountOption
	{
		NoCount = 0,
		Accumulate = 1,
		TouchRelease = 2
	}

	public enum TensionType
	{
		Directional = 0,
		Free = 1
	}

	[CompilerGenerated]
	private sealed class _003CGravityHandler_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UltimateJoystick _003C_003E4__this;

		private float _003Cspeed_003E5__2;

		private Vector3 _003CstartJoyPos_003E5__3;

		private float _003Ct_003E5__4;

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
		public _003CGravityHandler_003Ed__98(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CInputTransition_003Ed__99 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UltimateJoystick _003C_003E4__this;

		private float _003CcurrentAlpha_003E5__2;

		private float _003CcurrentScale_003E5__3;

		private float _003Ctransition_003E5__4;

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
		public _003CInputTransition_003Ed__99(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CTapCountdown_003Ed__100 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UltimateJoystick _003C_003E4__this;

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
		public _003CTapCountdown_003Ed__100(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CTapCountDelay_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UltimateJoystick _003C_003E4__this;

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
		public _003CTapCountDelay_003Ed__101(int _003C_003E1__state)
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

	private RectTransform baseTrans;

	private Vector2 defaultPos;

	private Vector2 joystickCenter;

	private Rect joystickRect;

	private CanvasGroup joystickGroup;

	private float radius;

	private RectTransform canvasRectTrans;

	[SerializeField]
	[InputControl(layout = "Vector2")]
	private string _controlPath;

	public RectTransform joystickBase;

	public RectTransform joystick;

	public ScalingAxis scalingAxis;

	public Anchor anchor;

	public float activationRange;

	public bool customActivationRange;

	public float activationWidth;

	public float activationHeight;

	public float activationPositionHorizontal;

	public float activationPositionVertical;

	public float joystickSize;

	public float radiusModifier;

	public float positionHorizontal;

	public float positionVertical;

	public bool dynamicPositioning;

	public float gravity;

	private bool gravityActive;

	public bool extendRadius;

	public Axis axis;

	public Boundary boundary;

	public float deadZone;

	public TapCountOption tapCountOption;

	public float tapCountDuration;

	public int targetTapCount;

	private float currentTapTime;

	private int tapCount;

	public bool disableVisuals;

	public bool inputTransition;

	public float transitionUntouchedDuration;

	public float transitionTouchedDuration;

	private float transitionUntouchedSpeed;

	private float transitionTouchedSpeed;

	public bool useFade;

	public float fadeUntouched;

	public float fadeTouched;

	public bool useScale;

	public float scaleTouched;

	public bool showHighlight;

	public Color highlightColor;

	public Image highlightBase;

	public Image highlightJoystick;

	public bool showTension;

	public Color tensionColorNone;

	public Color tensionColorFull;

	public TensionType tensionType;

	public float rotationOffset;

	public float tensionDeadZone;

	public List<Image> TensionAccents;

	private static Dictionary<string, UltimateJoystick> UltimateJoysticks;

	public string joystickName;

	private bool joystickState;

	private bool tapCountAchieved;

	public Canvas ParentCanvas
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

	protected override string controlPathInternal
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float HorizontalAxis
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float VerticalAxis
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public event Action OnPointerDownCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnPointerUpCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnDragCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnUpdatePositioning
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void OnPointerDown(PointerEventData touchInfo)
	{
	}

	public void OnDrag(PointerEventData touchInfo)
	{
	}

	public void OnPointerUp(PointerEventData touchInfo)
	{
	}

	private void ProcessInput(Vector2 inputPosition)
	{
	}

	private void OnTransformParentChanged()
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	public void UpdateParentCanvas()
	{
	}

	private void UpdateJoystickPositioning()
	{
	}

	private void UpdateJoystickCenter()
	{
	}

	private void TensionAccentDisplay()
	{
	}

	private void TensionAccentReset()
	{
	}

	[IteratorStateMachine(typeof(_003CGravityHandler_003Ed__98))]
	private IEnumerator GravityHandler()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CInputTransition_003Ed__99))]
	private IEnumerator InputTransition()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CTapCountdown_003Ed__100))]
	private IEnumerator TapCountdown()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CTapCountDelay_003Ed__101))]
	private IEnumerator TapCountDelay()
	{
		return null;
	}

	private void UpdatePositionValues()
	{
	}

	private static bool JoystickConfirmed(string joystickName)
	{
		return false;
	}

	private void ResetJoystick()
	{
	}

	public void UpdatePositioning()
	{
	}

	public float GetHorizontalAxis()
	{
		return 0f;
	}

	public float GetVerticalAxis()
	{
		return 0f;
	}

	public float GetHorizontalAxisRaw()
	{
		return 0f;
	}

	public float GetVerticalAxisRaw()
	{
		return 0f;
	}

	public float GetDistance()
	{
		return 0f;
	}

	public void UpdateHighlightColor(Color targetColor)
	{
	}

	public void UpdateTensionColors(Color targetTensionNone, Color targetTensionFull)
	{
	}

	public bool GetJoystickState()
	{
		return false;
	}

	public bool GetTapCount()
	{
		return false;
	}

	public void DisableJoystick()
	{
	}

	public void EnableJoystick()
	{
	}

	public bool InputInRange(Vector2 inputPosition)
	{
		return false;
	}

	public static UltimateJoystick GetUltimateJoystick(string joystickName)
	{
		return null;
	}

	public static float GetHorizontalAxis(string joystickName)
	{
		return 0f;
	}

	public static float GetVerticalAxis(string joystickName)
	{
		return 0f;
	}

	public static float GetHorizontalAxisRaw(string joystickName)
	{
		return 0f;
	}

	public static float GetVerticalAxisRaw(string joystickName)
	{
		return 0f;
	}

	public static float GetDistance(string joystickName)
	{
		return 0f;
	}

	public static bool GetJoystickState(string joystickName)
	{
		return false;
	}

	public static bool GetTapCount(string joystickName)
	{
		return false;
	}

	public static void DisableJoystick(string joystickName)
	{
	}

	public static void EnableJoystick(string joystickName)
	{
	}

	public static bool InputInRange(string joystickName, Vector2 inputPosition)
	{
		return false;
	}
}
