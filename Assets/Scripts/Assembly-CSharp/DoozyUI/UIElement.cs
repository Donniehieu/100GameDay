using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DoozyUI
{
	[AddComponentMenu("DoozyUI/UIElement", 1)]
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(Canvas))]
	[RequireComponent(typeof(CanvasGroup))]
	[RequireComponent(typeof(GraphicRaycaster))]
	[DisallowMultipleComponent]
	public class UIElement : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStartShow_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIElement _003C_003E4__this;

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
			public _003CStartShow_003Ed__65(int _003C_003E1__state)
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
		private sealed class _003CiShow_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIElement _003C_003E4__this;

			public bool instantAction;

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
			public _003CiShow_003Ed__76(int _003C_003E1__state)
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
		private sealed class _003CiHide_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIElement _003C_003E4__this;

			public bool instantAction;

			public bool shouldDisable;

			private float _003Cstart_003E5__2;

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
			public _003CiHide_003Ed__88(int _003C_003E1__state)
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
		private sealed class _003CInvokeEventAfterDelay_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool isDelay;

			public WaitForSecondsRealtime waitDelay;

			public UnityEvent @event;

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
			public _003CInvokeEventAfterDelay_003Ed__98(int _003C_003E1__state)
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
		private sealed class _003CTriggerShowInTheNextFrame_003Ed__108 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIElement _003C_003E4__this;

			public bool instantAction;

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
			public _003CTriggerShowInTheNextFrame_003Ed__108(int _003C_003E1__state)
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

		public const string LOOP_ANIMATIONS_ID = "UIElementLoopAnimations";

		public bool useBackground;

		public bool startHidden;

		public bool animateAtStart;

		public bool disableWhenHidden;

		public bool dontDisableCanvasWhenHidden;

		public bool disableGraphicRaycaster;

		public bool useCustomStartAnchoredPosition;

		public Vector3 customStartAnchoredPosition;

		public bool executeLayoutFix;

		public bool autoRegister;

		public bool isVisible;

		private bool containsChildUIElements;

		public Anim inAnimations;

		public UnityEvent OnInAnimationsStart;

		public UnityEvent OnInAnimationsFinish;

		public string inAnimationsPresetCategoryName;

		public string inAnimationsPresetName;

		public bool loadInAnimationsPresetAtRuntime;

		public Anim outAnimations;

		public UnityEvent OnOutAnimationsStart;

		public UnityEvent OnOutAnimationsFinish;

		public string outAnimationsPresetCategoryName;

		public string outAnimationsPresetName;

		public bool loadOutAnimationsPresetAtRuntime;

		private RectTransform m_rectTransform;

		private Canvas m_canvas;

		private GraphicRaycaster m_graphicRaycaster;

		private CanvasGroup m_canvasGroup;

		private Vector3 startPosition;

		private Vector3 startRotation;

		private Vector3 startScale;

		private float startAlpha;

		private float disableTimeBuffer;

		private Coroutine cShow;

		private Coroutine cHide;

		private Coroutine cAutoHide;

		private Coroutine cDisableButtonClicks;

		private Canvas[] childCanvas;

		private LayoutGroup[] layoutGroups;

		private WaitForSecondsRealtime waitDelay;

		private WaitForSecondsRealtime waitDuration;

		private UIElement bg;

		public RectTransform RectTransform => null;

		public Canvas Canvas => null;

		public GraphicRaycaster GraphicRaycaster => null;

		public CanvasGroup CanvasGroup => null;

		public bool InAnimationsEnabled => false;

		public bool OutAnimationsEnabled => false;

		public void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void MoveToCustomStartPosition()
		{
		}

		public void RegisterToUIManager()
		{
		}

		public void UnregisterFromUIManager()
		{
		}

		private void SetupElement()
		{
		}

		[IteratorStateMachine(typeof(_003CStartShow_003Ed__65))]
		private IEnumerator StartShow()
		{
			return null;
		}

		public void ShowUiElement()
		{
		}

		public void ShowUiElement(bool instantAction)
		{
		}

		private void ExecuteShow(bool instantAction)
		{
		}

		public void HideUiElement()
		{
		}

		public void HideUiElement(bool instantAction)
		{
		}

		private void ExecuteHide(bool instantAction)
		{
		}

		private void ResetRectTransform()
		{
		}

		private void LoadRuntimeInAnimationsPreset()
		{
		}

		private void ResetBeforeShow(bool resetPosition, bool resetAlpha)
		{
		}

		public void Show(bool instantAction)
		{
		}

		[IteratorStateMachine(typeof(_003CiShow_003Ed__76))]
		private IEnumerator iShow(bool instantAction)
		{
			return null;
		}

		private void StartMoveIn()
		{
		}

		private void FinishMoveIn()
		{
		}

		private void StartRotateIn()
		{
		}

		private void FinishRotateIn()
		{
		}

		private void StartScaleIn()
		{
		}

		private void FinishScaleIn()
		{
		}

		private void StartFadeIn()
		{
		}

		private void FinishFadeIn()
		{
		}

		private void LoadRuntimeOutAnimationsPreset()
		{
		}

		public void Hide(bool instantAction)
		{
		}

		public void Hide(bool instantAction, bool shouldDisable)
		{
		}

		[IteratorStateMachine(typeof(_003CiHide_003Ed__88))]
		private IEnumerator iHide(bool instantAction, bool shouldDisable = true)
		{
			return null;
		}

		private void StartMoveOut()
		{
		}

		private void FinishMoveOut()
		{
		}

		private void StartRotateOut()
		{
		}

		private void FinishRotateOut()
		{
		}

		private void StartScaleOut()
		{
		}

		private void FinishScaleOut()
		{
		}

		private void StartFadeOut()
		{
		}

		private void FinishFadeOut()
		{
		}

		private Coroutine InvokeEvent(UnityEvent @event, WaitForSecondsRealtime waitDelay, bool isDelay = true)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CInvokeEventAfterDelay_003Ed__98))]
		private IEnumerator InvokeEventAfterDelay(UnityEvent @event, WaitForSecondsRealtime waitDelay, bool isDelay)
		{
			return null;
		}

		private void TriggerInAnimationsEvents(bool instantAction)
		{
		}

		private void TriggerOutAnimationsEvents(bool instantAction)
		{
		}

		private void TriggerOutAnimationsEventsStart()
		{
		}

		private void InAnimationsStart()
		{
		}

		private void InAnimationsFinish()
		{
		}

		private void OutAnimationsStart()
		{
		}

		private void OutAnimationsFinish()
		{
		}

		private void ToggleCanvasAndGraphicRaycaster(bool isEnabled)
		{
		}

		private void ExecuteLayoutFix()
		{
		}

		[IteratorStateMachine(typeof(_003CTriggerShowInTheNextFrame_003Ed__108))]
		private IEnumerator TriggerShowInTheNextFrame(bool instantAction)
		{
			return null;
		}
	}
}
