using System;
using System.Threading.Tasks;

namespace Firebase.Analytics
{
	public sealed class FirebaseAnalytics
	{
		private static FirebaseApp app;

		private static FirebaseApp App => null;

		public static string EventAdImpression => null;

		public static string EventAddPaymentInfo => null;

		public static string EventAddShippingInfo => null;

		public static string EventAddToCart => null;

		public static string EventAddToWishlist => null;

		public static string EventAppOpen => null;

		public static string EventBeginCheckout => null;

		public static string EventCampaignDetails => null;

		public static string EventEarnVirtualCurrency => null;

		public static string EventGenerateLead => null;

		public static string EventJoinGroup => null;

		public static string EventLevelEnd => null;

		public static string EventLevelStart => null;

		public static string EventLevelUp => null;

		public static string EventLogin => null;

		public static string EventPostScore => null;

		public static string EventPurchase => null;

		public static string EventRefund => null;

		public static string EventRemoveFromCart => null;

		public static string EventScreenView => null;

		public static string EventSearch => null;

		public static string EventSelectContent => null;

		public static string EventSelectItem => null;

		public static string EventSelectPromotion => null;

		public static string EventShare => null;

		public static string EventSignUp => null;

		public static string EventSpendVirtualCurrency => null;

		public static string EventTutorialBegin => null;

		public static string EventTutorialComplete => null;

		public static string EventUnlockAchievement => null;

		public static string EventViewCart => null;

		public static string EventViewItem => null;

		public static string EventViewItemList => null;

		public static string EventViewPromotion => null;

		public static string EventViewSearchResults => null;

		public static string ParameterAchievementId => null;

		public static string ParameterAdFormat => null;

		public static string ParameterAdNetworkClickID => null;

		public static string ParameterAdPlatform => null;

		public static string ParameterAdSource => null;

		public static string ParameterAdUnitName => null;

		public static string ParameterAffiliation => null;

		public static string ParameterCP1 => null;

		public static string ParameterCampaign => null;

		public static string ParameterCampaignID => null;

		public static string ParameterCharacter => null;

		public static string ParameterContent => null;

		public static string ParameterContentType => null;

		public static string ParameterCoupon => null;

		public static string ParameterCreativeFormat => null;

		public static string ParameterCreativeName => null;

		public static string ParameterCreativeSlot => null;

		public static string ParameterCurrency => null;

		public static string ParameterDestination => null;

		public static string ParameterDiscount => null;

		public static string ParameterEndDate => null;

		public static string ParameterExtendSession => null;

		public static string ParameterFlightNumber => null;

		public static string ParameterGroupId => null;

		public static string ParameterIndex => null;

		public static string ParameterItemBrand => null;

		public static string ParameterItemCategory => null;

		public static string ParameterItemCategory2 => null;

		public static string ParameterItemCategory3 => null;

		public static string ParameterItemCategory4 => null;

		public static string ParameterItemCategory5 => null;

		public static string ParameterItemId => null;

		public static string ParameterItemListID => null;

		public static string ParameterItemListName => null;

		public static string ParameterItemName => null;

		public static string ParameterItemVariant => null;

		public static string ParameterItems => null;

		public static string ParameterLevel => null;

		public static string ParameterLevelName => null;

		public static string ParameterLocation => null;

		public static string ParameterLocationID => null;

		public static string ParameterMarketingTactic => null;

		public static string ParameterMedium => null;

		public static string ParameterMethod => null;

		public static string ParameterNumberOfNights => null;

		public static string ParameterNumberOfPassengers => null;

		public static string ParameterNumberOfRooms => null;

		public static string ParameterOrigin => null;

		public static string ParameterPaymentType => null;

		public static string ParameterPrice => null;

		public static string ParameterPromotionID => null;

		public static string ParameterPromotionName => null;

		public static string ParameterQuantity => null;

		public static string ParameterScore => null;

		public static string ParameterScreenClass => null;

		public static string ParameterScreenName => null;

		public static string ParameterSearchTerm => null;

		public static string ParameterShipping => null;

		public static string ParameterShippingTier => null;

		public static string ParameterSource => null;

		public static string ParameterSourcePlatform => null;

		public static string ParameterStartDate => null;

		public static string ParameterSuccess => null;

		public static string ParameterTax => null;

		public static string ParameterTerm => null;

		public static string ParameterTransactionId => null;

		public static string ParameterTravelClass => null;

		public static string ParameterValue => null;

		public static string ParameterVirtualCurrencyName => null;

		public static string UserPropertyAllowAdPersonalizationSignals => null;

		public static string UserPropertySignUpMethod => null;

		public static void ExportFix()
		{
		}

		static FirebaseAnalytics()
		{
		}

		private FirebaseAnalytics()
		{
		}

		public static void SetSessionTimeoutDuration(TimeSpan timeSpan)
		{
		}

		public static void SetAnalyticsCollectionEnabled(bool enabled)
		{
		}

		public static void LogEvent(string name, string parameterName, string parameterValue)
		{
		}

		public static void LogEvent(string name, string parameterName, double parameterValue)
		{
		}

		public static void LogEvent(string name, string parameterName, long parameterValue)
		{
		}

		public static void LogEvent(string name, string parameterName, int parameterValue)
		{
		}

		public static void LogEvent(string name)
		{
		}

		public static void LogEvent(string name, params Parameter[] parameters)
		{
		}

		public static void InitiateOnDeviceConversionMeasurementWithEmailAddress(string emailAddress)
		{
		}

		public static void SetUserProperty(string name, string property)
		{
		}

		public static void SetUserId(string userId)
		{
		}

		internal static void SetSessionTimeoutDurationInternal(long milliseconds)
		{
		}

		public static void ResetAnalyticsData()
		{
		}

		public static Task<string> GetAnalyticsInstanceIdAsync()
		{
			return null;
		}
	}
}
