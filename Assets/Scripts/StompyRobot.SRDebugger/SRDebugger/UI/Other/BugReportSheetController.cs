using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	public class BugReportSheetController : SRMonoBehaviourEx
	{
		[CompilerGenerated]
		private sealed class _003CSubmitCo_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BugReportSheetController _003C_003E4__this;

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
			public _003CSubmitCo_003Ed__18(int _003C_003E1__state)
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

		[RequiredField]
		public GameObject ButtonContainer;

		[RequiredField]
		public Text ButtonText;

		[RequiredField]
		public Button CancelButton;

		public Action CancelPressed;

		[RequiredField]
		public InputField DescriptionField;

		[RequiredField]
		public InputField EmailField;

		[RequiredField]
		public Slider ProgressBar;

		[RequiredField]
		public Text ResultMessageText;

		public Action ScreenshotComplete;

		[RequiredField]
		public Button SubmitButton;

		public Action<bool, string> SubmitComplete;

		public Action TakingScreenshot;

		public bool IsCancelButtonEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		public void Submit()
		{
		}

		public void Cancel()
		{
		}

		[IteratorStateMachine(typeof(_003CSubmitCo_003Ed__18))]
		private IEnumerator SubmitCo()
		{
			return null;
		}

		private void OnBugReportProgress(float progress)
		{
		}

		private void OnBugReportComplete(bool didSucceed, string errorMessage)
		{
		}

		protected void SetLoadingSpinnerVisible(bool visible)
		{
		}

		protected void ClearForm()
		{
		}

		protected void ShowErrorMessage(string userMessage, string serverMessage = null)
		{
		}

		protected void ClearErrorMessage()
		{
		}

		protected void SetFormEnabled(bool e)
		{
		}

		private string GetDefaultEmailFieldContents()
		{
			return null;
		}

		private void SetDefaultEmailFieldContents(string value)
		{
		}
	}
}
