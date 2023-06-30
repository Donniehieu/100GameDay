using System.Collections.Generic;
using BigBear.Core.Runtime.Singleton;
using UnityEngine;

namespace BigBear.Tracking
{
	[Singleton("TrackingManager", true)]
	[DefaultExecutionOrder(-5000)]
	public class TrackingManager : Singleton<TrackingManager>
	{
		public List<TrackerType> trackerTypes;

		public static List<ITracker> trackers;

		public static bool CanCollectUserData;

		public static void SetEnableUserDataCollected(bool isEnabled)
		{
		}

		public override void Init()
		{
		}

		public static void TrackScreen(string screen)
		{
		}

		public static void TrackEvent(string _eventName)
		{
		}

		public static void TrackEvent(string _eventName, string _paramName, string _paramValue)
		{
		}

		public static void TrackEvent(string _eventName, string _paramName, int _paramValue)
		{
		}

		public static void TrackEvent(string _eventName, string _paramName1, string _paramValue1, string _paramName2, string _paramValue2)
		{
		}

		public static void TrackEvent(string _eventName, string _paramName1, string _paramValue1, string _paramName2, int _paramValue2)
		{
		}

		public static void TrackEvent(string _eventName, string _paramName1, int _paramValue1, string _paramName2, int _paramValue2)
		{
		}

		public static void TrackEvent(string _eventName, string _paramName1, string _paramValue1, string _paramName2, string _paramValue2, string _paramName3, string _paramValue3)
		{
		}

		public static void TrackEvent(string _eventName, string _paramName1, string _paramValue1, string _paramName2, string _paramValue2, string _paramName3, int _paramValue3)
		{
		}

		public static void TrackEvent(string _eventName, params object[] parameterList)
		{
		}

		public static void TrackUserProperty(string _propertyName, string _propertyValue)
		{
		}

		public static void TrackLevelStart(int level)
		{
		}

		public static void TrackLevelCompleted(int level, int playTime)
		{
		}

		public static void TrackLevelFail(int level, int playTime)
		{
		}

		public TrackingManager()
		{
			((Singleton<T>)(object)this)._002Ector();
		}
	}
}
