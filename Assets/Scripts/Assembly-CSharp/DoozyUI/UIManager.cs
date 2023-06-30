using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DoozyUI
{
	[DisallowMultipleComponent]
	public class UIManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CExecuteTriggerTheTriggersInTheNextFrame_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CExecuteTriggerTheTriggersInTheNextFrame_003Ed__33(int _003C_003E1__state)
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

		private static UIManager _instance;

		private static bool applicationIsQuitting;

		private bool debugUIButtons;

		private int buttonClicksDisableLevel;

		private int backButtonDisableLevel;

		private float currentGameTimeScale;

		private static bool usesTMPro;

		private bool useTextMeshPro;

		private static int len;

		private static int count;

		private Transform canvasTransform;

		private UIElement background;

		public static Queue<UIElement> backgroundQueue;

		public static UIManager Instance => null;

		public bool ButtonClicksDisabled => false;

		public bool BackButtonDisabled => false;

		protected UIManager()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public UIElement GetBackgroundPanel(bool instantAction)
		{
			return null;
		}

		public void HideBackgroundPanel(UIElement bg, bool instantAction)
		{
		}

		public void InitBackgroundQueue(UIElement _background, Transform _canvasTranform)
		{
		}

		private void OnButtonAction(string buttonName, UIButton uiButton = null, UIButton.ButtonActionType actionType = UIButton.ButtonActionType.OnClick)
		{
		}

		public void SendButtonAction(UIButton uiButton, UIButton.ButtonActionType actionType)
		{
		}

		private void ListenForBackButton()
		{
		}

		public static void DisableBackButton()
		{
		}

		public static void EnableBackButton()
		{
		}

		public void TriggerTheTriggers(string triggerValue, DUI.EventType triggerType)
		{
		}

		[IteratorStateMachine(typeof(_003CExecuteTriggerTheTriggersInTheNextFrame_003Ed__33))]
		private IEnumerator ExecuteTriggerTheTriggersInTheNextFrame(string triggerValue, DUI.EventType triggerType)
		{
			return null;
		}

		public static void ApplicationQuit()
		{
		}
	}
}
