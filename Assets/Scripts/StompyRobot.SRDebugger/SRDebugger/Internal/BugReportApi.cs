using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SRDebugger.Services;
using UnityEngine.Networking;

namespace SRDebugger.Internal
{
	public class BugReportApi
	{
		[CompilerGenerated]
		private sealed class _003CSubmit_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BugReportApi _003C_003E4__this;

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
			public _003CSubmit_003Ed__19(int _003C_003E1__state)
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

		private readonly string _apiKey;

		private readonly BugReport _bugReport;

		private bool _isBusy;

		private UnityWebRequest _webRequest;

		public bool IsComplete
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool WasSuccessful
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string ErrorMessage
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

		public float Progress => 0f;

		public BugReportApi(BugReport report, string apiKey)
		{
		}

		[IteratorStateMachine(typeof(_003CSubmit_003Ed__19))]
		public IEnumerator Submit()
		{
			return null;
		}

		private void SetCompletionState(bool wasSuccessful)
		{
		}

		private static string BuildJsonRequest(BugReport report)
		{
			return null;
		}

		private static IList<IList<string>> CreateConsoleDump()
		{
			return null;
		}
	}
}
