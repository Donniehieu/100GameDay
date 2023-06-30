namespace BigBear.Tracking
{
	public class GameAnalyticsTracker : ITracker
	{
		public void Init()
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

		public void TrackEvent(string _eventName, string _paramName1, string _paramValue1, string _paramName2, float _paramValue2)
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
