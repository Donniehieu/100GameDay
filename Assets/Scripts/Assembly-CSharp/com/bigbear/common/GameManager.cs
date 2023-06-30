using BigBear.Ads;
using BigBear.Core.Runtime.Singleton;

namespace com.bigbear.common
{
	[Singleton("GameManager", true)]
	public class GameManager : Singleton<GameManager>
	{
		public PlayerProfiler PlayerProfiler;

		public BuildingData BuildingData;

		public BuildingUnlockData BuildingUnlockData;

		public BuildingPriceData BuildingPriceData;

		public ObjectPool ObjectPool;

		public BlockData BlockData;

		public BlockADSData BlockAdsData;

		public BreakADSData BreakAdsData;

		public SpriteData SpriteData;

		public DescriptionData DescriptionData;

		public override void Init()
		{
		}

		private void OnApplicationPause(bool hasFocus)
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void ADSPaid(AdsRevPaidEvent e)
		{
		}

		private void ADSClose(AdsCloseEvent e)
		{
		}

		private void ADSStart(AdsStartEvent e)
		{
		}

		public GameManager()
		{
			((Singleton<T>)(object)this)._002Ector();
		}
	}
}
