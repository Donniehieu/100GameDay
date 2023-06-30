using System;
using System.Runtime.InteropServices;

namespace Firebase.Analytics
{
	internal class FirebaseAnalyticsPINVOKE
	{
		protected class SWIGExceptionHelper
		{
			public delegate void ExceptionDelegate(string message);

			public delegate void ExceptionArgumentDelegate(string message, string paramName);

			private static ExceptionDelegate applicationDelegate;

			private static ExceptionDelegate arithmeticDelegate;

			private static ExceptionDelegate divideByZeroDelegate;

			private static ExceptionDelegate indexOutOfRangeDelegate;

			private static ExceptionDelegate invalidCastDelegate;

			private static ExceptionDelegate invalidOperationDelegate;

			private static ExceptionDelegate ioDelegate;

			private static ExceptionDelegate nullReferenceDelegate;

			private static ExceptionDelegate outOfMemoryDelegate;

			private static ExceptionDelegate overflowDelegate;

			private static ExceptionDelegate systemDelegate;

			private static ExceptionArgumentDelegate argumentDelegate;

			private static ExceptionArgumentDelegate argumentNullDelegate;

			private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

			[PreserveSig]
			public static extern void SWIGRegisterExceptionCallbacks_FirebaseAnalytics(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[PreserveSig]
			public static extern void SWIGRegisterExceptionCallbacksArgument_FirebaseAnalytics(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingApplicationException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingArithmeticException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingDivideByZeroException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingIndexOutOfRangeException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingInvalidCastException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingInvalidOperationException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingIOException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingNullReferenceException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingOutOfMemoryException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingOverflowException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingSystemException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
			private static void SetPendingArgumentException(string message, string paramName)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
			private static void SetPendingArgumentNullException(string message, string paramName)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
			}

			static SWIGExceptionHelper()
			{
			}
		}

		public class SWIGPendingException
		{
			[ThreadStatic]
			private static Exception pendingException;

			private static int numExceptionsPending;

			private static object exceptionsLock;

			public static bool Pending => false;

			public static void Set(Exception e)
			{
			}

			public static Exception Retrieve()
			{
				return null;
			}

			static SWIGPendingException()
			{
			}
		}

		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[PreserveSig]
			public static extern void SWIGRegisterStringCallback_FirebaseAnalytics(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback(typeof(SWIGStringDelegate))]
			private static string CreateString(string cString)
			{
				return null;
			}

			static SWIGStringHelper()
			{
			}
		}

		protected static SWIGExceptionHelper swigExceptionHelper;

		protected static SWIGStringHelper swigStringHelper;

		static FirebaseAnalyticsPINVOKE()
		{
		}

		[PreserveSig]
		public static extern void ExportFix();

		[PreserveSig]
		public static extern string kEventAdImpression_get();

		[PreserveSig]
		public static extern string kEventAddPaymentInfo_get();

		[PreserveSig]
		public static extern string kEventAddShippingInfo_get();

		[PreserveSig]
		public static extern string kEventAddToCart_get();

		[PreserveSig]
		public static extern string kEventAddToWishlist_get();

		[PreserveSig]
		public static extern string kEventAppOpen_get();

		[PreserveSig]
		public static extern string kEventBeginCheckout_get();

		[PreserveSig]
		public static extern string kEventCampaignDetails_get();

		[PreserveSig]
		public static extern string kEventEarnVirtualCurrency_get();

		[PreserveSig]
		public static extern string kEventGenerateLead_get();

		[PreserveSig]
		public static extern string kEventJoinGroup_get();

		[PreserveSig]
		public static extern string kEventLevelEnd_get();

		[PreserveSig]
		public static extern string kEventLevelStart_get();

		[PreserveSig]
		public static extern string kEventLevelUp_get();

		[PreserveSig]
		public static extern string kEventLogin_get();

		[PreserveSig]
		public static extern string kEventPostScore_get();

		[PreserveSig]
		public static extern string kEventPurchase_get();

		[PreserveSig]
		public static extern string kEventRefund_get();

		[PreserveSig]
		public static extern string kEventRemoveFromCart_get();

		[PreserveSig]
		public static extern string kEventScreenView_get();

		[PreserveSig]
		public static extern string kEventSearch_get();

		[PreserveSig]
		public static extern string kEventSelectContent_get();

		[PreserveSig]
		public static extern string kEventSelectItem_get();

		[PreserveSig]
		public static extern string kEventSelectPromotion_get();

		[PreserveSig]
		public static extern string kEventShare_get();

		[PreserveSig]
		public static extern string kEventSignUp_get();

		[PreserveSig]
		public static extern string kEventSpendVirtualCurrency_get();

		[PreserveSig]
		public static extern string kEventTutorialBegin_get();

		[PreserveSig]
		public static extern string kEventTutorialComplete_get();

		[PreserveSig]
		public static extern string kEventUnlockAchievement_get();

		[PreserveSig]
		public static extern string kEventViewCart_get();

		[PreserveSig]
		public static extern string kEventViewItem_get();

		[PreserveSig]
		public static extern string kEventViewItemList_get();

		[PreserveSig]
		public static extern string kEventViewPromotion_get();

		[PreserveSig]
		public static extern string kEventViewSearchResults_get();

		[PreserveSig]
		public static extern string kParameterAchievementId_get();

		[PreserveSig]
		public static extern string kParameterAdFormat_get();

		[PreserveSig]
		public static extern string kParameterAdNetworkClickID_get();

		[PreserveSig]
		public static extern string kParameterAdPlatform_get();

		[PreserveSig]
		public static extern string kParameterAdSource_get();

		[PreserveSig]
		public static extern string kParameterAdUnitName_get();

		[PreserveSig]
		public static extern string kParameterAffiliation_get();

		[PreserveSig]
		public static extern string kParameterCP1_get();

		[PreserveSig]
		public static extern string kParameterCampaign_get();

		[PreserveSig]
		public static extern string kParameterCampaignID_get();

		[PreserveSig]
		public static extern string kParameterCharacter_get();

		[PreserveSig]
		public static extern string kParameterContent_get();

		[PreserveSig]
		public static extern string kParameterContentType_get();

		[PreserveSig]
		public static extern string kParameterCoupon_get();

		[PreserveSig]
		public static extern string kParameterCreativeFormat_get();

		[PreserveSig]
		public static extern string kParameterCreativeName_get();

		[PreserveSig]
		public static extern string kParameterCreativeSlot_get();

		[PreserveSig]
		public static extern string kParameterCurrency_get();

		[PreserveSig]
		public static extern string kParameterDestination_get();

		[PreserveSig]
		public static extern string kParameterDiscount_get();

		[PreserveSig]
		public static extern string kParameterEndDate_get();

		[PreserveSig]
		public static extern string kParameterExtendSession_get();

		[PreserveSig]
		public static extern string kParameterFlightNumber_get();

		[PreserveSig]
		public static extern string kParameterGroupId_get();

		[PreserveSig]
		public static extern string kParameterIndex_get();

		[PreserveSig]
		public static extern string kParameterItemBrand_get();

		[PreserveSig]
		public static extern string kParameterItemCategory_get();

		[PreserveSig]
		public static extern string kParameterItemCategory2_get();

		[PreserveSig]
		public static extern string kParameterItemCategory3_get();

		[PreserveSig]
		public static extern string kParameterItemCategory4_get();

		[PreserveSig]
		public static extern string kParameterItemCategory5_get();

		[PreserveSig]
		public static extern string kParameterItemId_get();

		[PreserveSig]
		public static extern string kParameterItemListID_get();

		[PreserveSig]
		public static extern string kParameterItemListName_get();

		[PreserveSig]
		public static extern string kParameterItemName_get();

		[PreserveSig]
		public static extern string kParameterItemVariant_get();

		[PreserveSig]
		public static extern string kParameterItems_get();

		[PreserveSig]
		public static extern string kParameterLevel_get();

		[PreserveSig]
		public static extern string kParameterLevelName_get();

		[PreserveSig]
		public static extern string kParameterLocation_get();

		[PreserveSig]
		public static extern string kParameterLocationID_get();

		[PreserveSig]
		public static extern string kParameterMarketingTactic_get();

		[PreserveSig]
		public static extern string kParameterMedium_get();

		[PreserveSig]
		public static extern string kParameterMethod_get();

		[PreserveSig]
		public static extern string kParameterNumberOfNights_get();

		[PreserveSig]
		public static extern string kParameterNumberOfPassengers_get();

		[PreserveSig]
		public static extern string kParameterNumberOfRooms_get();

		[PreserveSig]
		public static extern string kParameterOrigin_get();

		[PreserveSig]
		public static extern string kParameterPaymentType_get();

		[PreserveSig]
		public static extern string kParameterPrice_get();

		[PreserveSig]
		public static extern string kParameterPromotionID_get();

		[PreserveSig]
		public static extern string kParameterPromotionName_get();

		[PreserveSig]
		public static extern string kParameterQuantity_get();

		[PreserveSig]
		public static extern string kParameterScore_get();

		[PreserveSig]
		public static extern string kParameterScreenClass_get();

		[PreserveSig]
		public static extern string kParameterScreenName_get();

		[PreserveSig]
		public static extern string kParameterSearchTerm_get();

		[PreserveSig]
		public static extern string kParameterShipping_get();

		[PreserveSig]
		public static extern string kParameterShippingTier_get();

		[PreserveSig]
		public static extern string kParameterSource_get();

		[PreserveSig]
		public static extern string kParameterSourcePlatform_get();

		[PreserveSig]
		public static extern string kParameterStartDate_get();

		[PreserveSig]
		public static extern string kParameterSuccess_get();

		[PreserveSig]
		public static extern string kParameterTax_get();

		[PreserveSig]
		public static extern string kParameterTerm_get();

		[PreserveSig]
		public static extern string kParameterTransactionId_get();

		[PreserveSig]
		public static extern string kParameterTravelClass_get();

		[PreserveSig]
		public static extern string kParameterValue_get();

		[PreserveSig]
		public static extern string kParameterVirtualCurrencyName_get();

		[PreserveSig]
		public static extern string kUserPropertyAllowAdPersonalizationSignals_get();

		[PreserveSig]
		public static extern string kUserPropertySignUpMethod_get();

		[PreserveSig]
		public static extern IntPtr new_Parameter__SWIG_0(string jarg1, string jarg2);

		[PreserveSig]
		public static extern IntPtr new_Parameter__SWIG_1(string jarg1, long jarg2);

		[PreserveSig]
		public static extern IntPtr new_Parameter__SWIG_2(string jarg1, double jarg2);

		[PreserveSig]
		public static extern void delete_Parameter(HandleRef jarg1);

		[PreserveSig]
		public static extern void SetAnalyticsCollectionEnabled(bool jarg1);

		[PreserveSig]
		public static extern void LogEvent__SWIG_0(string jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern void LogEvent__SWIG_1(string jarg1, string jarg2, double jarg3);

		[PreserveSig]
		public static extern void LogEvent__SWIG_2(string jarg1, string jarg2, long jarg3);

		[PreserveSig]
		public static extern void LogEvent__SWIG_3(string jarg1, string jarg2, int jarg3);

		[PreserveSig]
		public static extern void LogEvent__SWIG_4(string jarg1);

		[PreserveSig]
		public static extern void LogEvent__SWIG_5(string jarg1, IntPtr arg, int jarg2);

		[PreserveSig]
		public static extern void InitiateOnDeviceConversionMeasurementWithEmailAddress(string jarg1);

		[PreserveSig]
		public static extern void SetUserProperty(string jarg1, string jarg2);

		[PreserveSig]
		public static extern void SetUserId(string jarg1);

		[PreserveSig]
		internal static extern void SetSessionTimeoutDurationInternal(long jarg1);

		[PreserveSig]
		public static extern void ResetAnalyticsData();

		[PreserveSig]
		public static extern IntPtr GetAnalyticsInstanceId();
	}
}
