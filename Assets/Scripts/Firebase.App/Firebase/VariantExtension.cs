using System.Collections.Generic;

namespace Firebase
{
	internal static class VariantExtension
	{
		internal enum KeyOptions
		{
			UseObjectKeys = 0,
			UseStringKeys = 1
		}

		private const KeyOptions DefaultKeyOptions = KeyOptions.UseObjectKeys;

		public static object ToObject(this Variant variant)
		{
			return null;
		}

		public static object ToObject(this Variant variant, KeyOptions options)
		{
			return null;
		}

		private static object ToObjectInternal(this Variant variant, KeyOptions options)
		{
			return null;
		}

		public static IDictionary<string, object> ToStringVariantMap(this VariantVariantMap originalMap)
		{
			return null;
		}

		public static IDictionary<string, object> ToStringVariantMap(this VariantVariantMap originalMap, KeyOptions options)
		{
			return null;
		}
	}
}
