using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DoozyUI
{
	[DisallowMultipleComponent]
	[AddComponentMenu("DoozyUI/UIButton", 2)]
	[RequireComponent(typeof(RectTransform), typeof(Button))]
	public class UIButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler
	{
		public enum ButtonAnimationType
		{
			Punch = 0,
			State = 1
		}

		public enum ButtonActionType
		{
			OnClick = 0
		}

		public enum ButtonClickType
		{
			OnClick = 0
		}

		public enum SingleClickMode
		{
			Instant = 0,
			Delayed = 1
		}

		[CompilerGenerated]
		private sealed class _003CIUpdateStartPosition_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIButton _003C_003E4__this;

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
			public _003CIUpdateStartPosition_003Ed__66(int _003C_003E1__state)
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
		private sealed class _003CiDeselectButton_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIButton _003C_003E4__this;

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
			public _003CiDeselectButton_003Ed__77(int _003C_003E1__state)
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
		private sealed class _003CiExecuteClickActionsWithDelay_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIButton _003C_003E4__this;

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
			public _003CiExecuteClickActionsWithDelay_003Ed__81(int _003C_003E1__state)
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
		private sealed class _003CiDisableButton_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIButton _003C_003E4__this;

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
			public _003CiDisableButton_003Ed__87(int _003C_003E1__state)
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
		private sealed class _003CClickRegistered_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIButton _003C_003E4__this;

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
			public _003CClickRegistered_003Ed__91(int _003C_003E1__state)
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

		public const float BETWEEN_CLICKS_DISABLE_INTERVAL = 0.4f;

		public const float DOUBLE_CLICK_REGISTER_INTERVAL = 0.2f;

		public const float DESELECT_BUTTON_DELAY = 0.1f;

		public const string NORMAL_LOOP_ID = "ButtonNormalLoop";

		public bool debug;

		public string buttonCategory;

		public string buttonName;

		public bool allowMultipleClicks;

		public bool deselectButtonOnClick;

		public float disableButtonInterval;

		public bool useOnClickAnimations;

		public bool waitForOnClickAnimation;

		public SingleClickMode singleClickMode;

		public bool customOnClickSound;

		public UnityEvent OnClick;

		public ButtonAnimationType onClickAnimationType;

		public string onClickPunchPresetCategory;

		public string onClickPunchPresetName;

		public bool loadOnClickPunchPresetAtRuntime;

		public Punch onClickPunch;

		public string onClickStatePresetCategory;

		public string onClickStatePresetName;

		public bool loadOnClickStatePresetAtRuntime;

		public Anim onClickState;

		public bool useOnDoubleClick;

		public float doubleClickRegisterInterval;

		private float doubleClickTimeoutCounter;

		private bool clickedOnce;

		public bool useOnLongClick;

		public string normalLoopPresetCategory;

		public string normalLoopPresetName;

		public bool loadNormalLoopPresetAtRuntime;

		public Loop normalLoop;

		private bool normalLoopIsPlaying;

		private RectTransform m_rectTransform;

		private Button m_button;

		private Vector3 startPosition;

		private Vector3 startRotation;

		private Vector3 startScale;

		private float startAlpha;

		private Coroutine cDisableButton;

		private bool Initialized;

		private bool isControlledByLayoutGroup;

		private WaitForSecondsRealtime waitDelaySelect;

		private WaitForSecondsRealtime waitDelayClick;

		private WaitForSecondsRealtime waitDuration;

		private WaitForEndOfFrame waitForEnd;

		public bool IsSelected => false;

		public RectTransform RectTransform => null;

		public Button Button => null;

		public bool Interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool ButtonClicksDisabled => false;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CIUpdateStartPosition_003Ed__66))]
		private IEnumerator IUpdateStartPosition()
		{
			return null;
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void LoadRuntimePunchPresets()
		{
		}

		private void LoadRuntimeStatePresets()
		{
		}

		private void LoadRuntimeLoopPresets()
		{
		}

		private void AddActionsListeners()
		{
		}

		private void StartNormalLoop(bool forced = false)
		{
		}

		private void StopNormalLoop()
		{
		}

		private void ResetRectTransform()
		{
		}

		private void DeselectButton(float delay)
		{
		}

		[IteratorStateMachine(typeof(_003CiDeselectButton_003Ed__77))]
		private IEnumerator iDeselectButton(float delay)
		{
			return null;
		}

		private void ExecuteOnClickActions()
		{
		}

		public void SendButtonClick()
		{
		}

		public void SendButtonClick(bool playSound, bool animate, bool forced = false)
		{
		}

		[IteratorStateMachine(typeof(_003CiExecuteClickActionsWithDelay_003Ed__81))]
		private IEnumerator iExecuteClickActionsWithDelay()
		{
			return null;
		}

		public void ExecutePunch(Punch punch, bool deselectButton = false, bool forced = false)
		{
		}

		public void ExecuteState(Anim anim, bool deselectButton = false, bool forced = false)
		{
		}

		public void EnableButton()
		{
		}

		public void DisableButton()
		{
		}

		public void DisableButton(float duration)
		{
		}

		[IteratorStateMachine(typeof(_003CiDisableButton_003Ed__87))]
		private IEnumerator iDisableButton(float duration)
		{
			return null;
		}

		private void DisableButtonAfterClick()
		{
		}

		private void UnityEngine_002EEventSystems_002EIPointerClickHandler_002EOnPointerClick(PointerEventData eventData)
		{
		}

		private void RegisterClick()
		{
		}

		[IteratorStateMachine(typeof(_003CClickRegistered_003Ed__91))]
		private IEnumerator ClickRegistered()
		{
			return null;
		}

		public void ExecuteClick(bool forced = false)
		{
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}
	}
}
