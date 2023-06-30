using System;
using System.Collections.Generic;

namespace BigBear.Ads
{
	public class ApplovinModule : IAdsModule
	{
		private Action onRewardAdsSkip;

		private Action onRewardAdsClosed;

		private Action onInterAdsClosed;

		private Action onAppOpenAdsClosed;

		private bool IsRewarded;

		private AdManager adManger;

		private Dictionary<AdsType, string> adsUnitIds;

		public void Init(AdManager _adManger, Dictionary<AdsType, string> androidUnitIds, Dictionary<AdsType, string> iosUnitIds, params string[] others)
		{
		}

		public void CheckLoadAds()
		{
		}

		private void LoadInterstitial()
		{
		}

		public bool IsInterstitalAdsLoaded()
		{
			return false;
		}

		public bool ShowInterAds(Action _onInterClosed)
		{
			return false;
		}

		private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void InterstitialFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo arg3)
		{
		}

		private void OnInterstitialDismissedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo arg2)
		{
		}

		private void OnInterstitialRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo arg2)
		{
		}

		public void InitializeBannerAds()
		{
		}

		private MaxSdkBase.BannerPosition GetBannerPos(BannerPos pos)
		{
			return default(MaxSdkBase.BannerPosition);
		}

		public void ShowBanner(BannerPos bannerPos)
		{
		}

		public void HideBanner(BannerPos bannerPos)
		{
		}

		private void LoadRewardedAd()
		{
		}

		public bool IsRewardAdsLoaded()
		{
			return false;
		}

		public bool ShowRewardAds(Action _onRewardClose, Action _onRewardAdSkip)
		{
			return false;
		}

		private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo arg3)
		{
		}

		private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo arg2)
		{
		}

		private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo arg2)
		{
		}

		private void OnRewardedAdDismissedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void LoadAppOpenAd()
		{
		}

		public bool IsAppOpenAdsLoaded()
		{
			return false;
		}

		public bool ShowAppOpenAds(Action _onAppOpenClose)
		{
			return false;
		}

		private void OnAppOpenRevPaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnAppOpenDismissedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}
	}
}
