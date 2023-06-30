using System;
using System.Collections.Generic;
using BigBear.Core.Runtime.Singleton;
using UnityEngine;

namespace BigBear.Ads
{
	[Singleton("AdManger", true)]
	public class AdManager : SerializedSingleton<AdManager>
	{
		public bool isFakeAds;

		public AdsNetworkConfig adsNetworkConfig;

		public AdsConfig adsConfig;

		[SerializeField]
		private Dictionary<AdsType, string> AndroidUnitId;

		[SerializeField]
		private Dictionary<AdsType, string> IOSUnitId;

		private IAdsModule _adsModule;

		private DateTime lastTimeShowInter;

		private float loadAdsTimer;

		private float nextInterTime;

		private AdsStartEvent adsStartEvent;

		private AdsCloseEvent adsCloseEvent;

		private AdsRevPaidEvent adsRevPaidEvent;

		public Dictionary<AdsType, string> IosUnitId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Init()
		{
		}

		private void Start()
		{
		}

		public void Update()
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private IAdsModule CreateAdModule(AdsModuleType adsModuleType)
		{
			return null;
		}

		public void ResetAdsParameter()
		{
		}

		public void SetAdsConfig(AdsConfig _newAdsConfig)
		{
		}

		public void OnAdsRevPaid(AdsType _adType, string _unitId, double _adRev)
		{
		}

		private void CheckShowBanner()
		{
		}

		public void SetShouldShowBanner(bool shouldShow)
		{
		}

		public void ShowBanner(BannerPos bannerPos)
		{
		}

		public void HideBanner(BannerPos bannerPos)
		{
		}

		public void OnInterStarted()
		{
		}

		public void OnInterClosed()
		{
		}

		public void SetShouldShowInter(bool shouldShow)
		{
		}

		public void ShowInterstitialAds(Action closeCallback = null)
		{
		}

		public bool CanInterstitalAdsShow()
		{
			return false;
		}

		public bool IsInterstitalAdsLoaded()
		{
			return false;
		}

		private void SetNextInterTime(bool isAfterReward)
		{
		}

		public void OnRewardedStarted()
		{
		}

		public void OnRewardedClosed()
		{
		}

		public bool ShowRewardedVideo(Action closeRewardCallback, Action skipRewardCallback, string placement = null)
		{
			return false;
		}

		public bool IsRewardAdsLoaded()
		{
			return false;
		}

		private bool CheckShowInterWhenNoReward(Action closeRewardCallback)
		{
			return false;
		}

		public bool IsRewardedVideoLoaded()
		{
			return false;
		}

		public void OnAppOpenStarted()
		{
		}

		public void OnAppOpenClose()
		{
		}

		public void SetShouldShowAppOpen(bool shouldShow)
		{
		}

		public void ShowAppOpenAds(Action closeCallback = null)
		{
		}

		public bool IsAppOpenAdsLoaded()
		{
			return false;
		}

		public AdManager()
		{
			((SerializedSingleton<T>)(object)this)._002Ector();
		}
	}
}
