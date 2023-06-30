using BigBear.Core.Runtime.EventManager;

namespace BigBear.Ads
{
	public class AdsRevPaidEvent : GameEvent
	{
		public AdsType adsType;

		public string adUnitId;

		public double revenue;
	}
}
