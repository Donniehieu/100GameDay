using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BigBear.Tracking
{
	public class FacebookTracker : ITracker
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTryToLogEvent_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Action logTask;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private bool canCollectData;

		private Dictionary<string, object> parameters;

		public void Init()
		{
		}

		private void InitCallback()
		{
		}

		private void OnHideUnity(bool isGameShown)
		{
		}

		[AsyncStateMachine(typeof(_003CTryToLogEvent_003Ed__5))]
		private void TryToLogEvent(Action logTask)
		{
		}

		public void TrackScreen(string screen)
		{
		}

		public void TrackEvent(string _eventName)
		{
		}

		public void TrackEvent(string _eventName, string _paramName, string _paramValue)
		{
		}

		public void TrackEvent(string _eventName, string _paramName, int _paramValue)
		{
		}

		public void TrackEvent(string _eventName, string _paramName1, string _paramValue1, string _paramName2, string _paramValue2)
		{
		}

		public void TrackEvent(string _eventName, string _paramName1, string _paramValue1, string _paramName2, int _paramValue2)
		{
		}

		public void TrackEvent(string _eventName, string _paramName1, int _paramValue1, string _paramName2, int _paramValue2)
		{
		}

		public void TrackEvent(string _eventName, string _paramName1, string _paramValue1, string _paramName2, string _paramValue2, string _paramName3, string _paramValue3)
		{
		}

		public void TrackEvent(string _eventName, string _paramName1, string _paramValue1, string _paramName2, string _paramValue2, string _paramName3, int _paramValue3)
		{
		}

		public void TrackEvent(string _eventName, params object[] parameterList)
		{
		}

		public void TrackUserProperty(string _propertyName, string _propertyValue)
		{
		}

		public void SetCollectDataEnabled(bool isEnabled)
		{
		}

		public void TrackLevelStart(int level)
		{
		}

		public void TrackLevelCompleted(int level, int playTime)
		{
		}

		public void TrackLevelFail(int level, int playTime)
		{
		}
	}
}
