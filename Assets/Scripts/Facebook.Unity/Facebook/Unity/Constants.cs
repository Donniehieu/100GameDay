using System;

namespace Facebook.Unity
{
	internal static class Constants
	{
		public const string CallbackIdKey = "callback_id";

		public const string AccessTokenKey = "access_token";

		public const string UrlKey = "url";

		public const string RefKey = "ref";

		public const string ExtrasKey = "extras";

		public const string TargetUrlKey = "target_url";

		public const string CancelledKey = "cancelled";

		public const string ErrorKey = "error";

		public const string HasLicenseKey = "has_license";

		public const string OnPayCompleteMethodName = "OnPayComplete";

		public const string OnShareCompleteMethodName = "OnShareLinkComplete";

		public const string OnAppRequestsCompleteMethodName = "OnAppRequestsComplete";

		public const string OnGroupCreateCompleteMethodName = "OnGroupCreateComplete";

		public const string OnGroupJoinCompleteMethodName = "OnJoinGroupComplete";

		public const string GraphApiVersion = "v15.0";

		public const string GraphUrlFormat = "https://graph.{0}/{1}/";

		public const string UserLikesPermission = "user_likes";

		public const string EmailPermission = "email";

		public const string PublishActionsPermission = "publish_actions";

		public const string PublishPagesPermission = "publish_pages";

		public const string EventBindingKeysClassName = "class_name";

		public const string EventBindingKeysIndex = "index";

		public const string EventBindingKeysPath = "path";

		public const string EventBindingKeysEventName = "event_name";

		public const string EventBindingKeysEventType = "event_type";

		public const string EventBindingKeysAppVersion = "app_version";

		public const string EventBindingKeysText = "text";

		public const string EventBindingKeysHint = "hint";

		public const string EventBindingKeysDescription = "description";

		public const string EventBindingKeysTag = "tag";

		public const string EventBindingKeysSection = "section";

		public const string EventBindingKeysRow = "row";

		public const string EventBindingKeysMatchBitmask = "match_bitmask";

		public const int MaxPathDepth = 35;

		private static FacebookUnityPlatform? currentPlatform;

		public static Uri GraphUrl => null;

		public static string GraphApiUserAgent => null;

		public static bool IsMobile => false;

		public static bool IsEditor => false;

		public static bool IsWeb => false;

		public static string UnitySDKUserAgentSuffixLegacy => null;

		public static string UnitySDKUserAgent => null;

		public static bool DebugMode => false;

		public static FacebookUnityPlatform CurrentPlatform
		{
			get
			{
				return default(FacebookUnityPlatform);
			}
			set
			{
			}
		}

		private static FacebookUnityPlatform GetCurrentPlatform()
		{
			return default(FacebookUnityPlatform);
		}
	}
}
