namespace BigBear.Core.Runtime.Extensions
{
	public static class BoolExtensions
	{
		public static bool IsTrue(this bool @bool)
		{
			return false;
		}

		public static bool IsFalse(this bool @bool)
		{
			return false;
		}

		public static bool Toggle(this bool @bool)
		{
			return false;
		}

		public static int ToInt(this bool @bool)
		{
			return 0;
		}

		public static string ToLowerString(this bool @bool)
		{
			return null;
		}

		public static string ToString(this bool @bool, string trueString, string falseString)
		{
			return null;
		}

		public static T ToType<T>(this bool @bool, T trueValue, T falseValue)
		{
			return default(T);
		}
	}
}
