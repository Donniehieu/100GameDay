using System;
using System.Collections.Generic;

namespace BigBear.Ads
{
	public interface IAdsModule
	{
		void Init(AdManager _adManger, Dictionary<AdsType, string> androidUnitIds, Dictionary<AdsType, string> iosUnitIds, params string[] others);

		bool IsInterstitalAdsLoaded();

		bool ShowInterAds(Action _onInterClosed);

		void InitializeBannerAds();

		void ShowBanner(BannerPos bannerPos);

		void HideBanner(BannerPos bannerPos);

		bool IsRewardAdsLoaded();

		bool ShowRewardAds(Action _onRewardClose, Action _onRewardAdSkip);

		void CheckLoadAds();

		bool IsAppOpenAdsLoaded();

		bool ShowAppOpenAds(Action _onAppOpenClose);
	}
}
