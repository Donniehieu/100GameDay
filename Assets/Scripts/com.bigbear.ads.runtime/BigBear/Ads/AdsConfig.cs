using System;
using UnityEngine;

namespace BigBear.Ads
{
	[Serializable]
	public class AdsConfig
	{
		public bool isTestAds;

		public float checkLoadAdsInterval;

		public bool shouldShowBanner;

		public BannerPos bannerPos;

		public Color bannerBackgroundColor;

		public bool shouldShowAppOpen;

		public bool shouldShowInter;

		public float interAdsIntervalTime;

		public float interAfterRewardTime;

		public bool isShowInterWhenNoReward;
	}
}
