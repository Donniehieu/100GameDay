using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SRDebugger.UI.Other;
using SRF.Service;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(BugReportPopoverService))]
	public class BugReportPopoverService : SRServiceBase<BugReportPopoverService>
	{
		[CompilerGenerated]
		private sealed class _003COpenCo_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool takeScreenshot;

			public BugReportPopoverService _003C_003E4__this;

			public string descriptionText;

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
			public _003COpenCo_003Ed__7(int _003C_003E1__state)
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

		private BugReportCompleteCallback _callback;

		private bool _isVisible;

		private BugReportPopoverRoot _popover;

		private BugReportSheetController _sheet;

		public bool IsShowingPopover => false;

		public void ShowBugReporter(BugReportCompleteCallback callback, bool takeScreenshotFirst = true, string descriptionText = null)
		{
		}

		[IteratorStateMachine(typeof(_003COpenCo_003Ed__7))]
		private IEnumerator OpenCo(bool takeScreenshot, string descriptionText)
		{
			return null;
		}

		private void SubmitComplete(bool didSucceed, string errorMessage)
		{
		}

		private void CancelPressed()
		{
		}

		private void OnComplete(bool success, string errorMessage, bool close)
		{
		}

		private void TakingScreenshot()
		{
		}

		private void ScreenshotComplete()
		{
		}

		protected override void Awake()
		{
		}

		private void Load()
		{
		}

		public BugReportPopoverService()
		{
			((SRServiceBase<T>)(object)this)._002Ector();
		}
	}
}
