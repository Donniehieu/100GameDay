namespace Facebook.Unity.Mobile
{
	internal interface IMobileFacebookCallbackHandler : IFacebookCallbackHandler
	{
		void OnFetchDeferredAppLinkComplete(string message);

		void OnRefreshCurrentAccessTokenComplete(string message);

		void OnFriendFinderComplete(string message);

		void OnUploadImageToMediaLibraryComplete(string message);

		void OnUploadVideoToMediaLibraryComplete(string message);

		void OnOnIAPReadyComplete(string message);

		void OnGetCatalogComplete(string message);

		void OnGetPurchasesComplete(string message);

		void OnPurchaseComplete(string message);

		void OnConsumePurchaseComplete(string message);

		void OnInitCloudGameComplete(string message);

		void OnGameLoadCompleteComplete(string message);

		void OnScheduleAppToUserNotificationComplete(string message);

		void OnLoadInterstitialAdComplete(string message);

		void OnShowInterstitialAdComplete(string message);

		void OnLoadRewardedVideoComplete(string message);

		void OnShowRewardedVideoComplete(string message);

		void OnGetPayloadComplete(string message);

		void OnPostSessionScoreComplete(string message);

		void OnGetTournamentComplete(string message);

		void OnShareTournamentComplete(string message);

		void OnCreateTournamentComplete(string message);

		void OnPostTournamentScoreComplete(string message);

		void OnGetTournamentsComplete(string message);

		void OnUpdateTournamentComplete(string message);

		void OnTournamentDialogSuccess(string message);

		void OnTournamentDialogCancel(string message);

		void OnTournamentDialogError(string message);

		void OnOpenAppStoreComplete(string message);

		void OnCreateGamingContextComplete(string message);

		void OnSwitchGamingContextComplete(string message);

		void OnChooseGamingContextComplete(string message);

		void OnGetCurrentGamingContextComplete(string message);
	}
}
