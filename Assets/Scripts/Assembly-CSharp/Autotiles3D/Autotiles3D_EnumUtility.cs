using System;
using System.Collections.Generic;

namespace Autotiles3D
{
	public static class Autotiles3D_EnumUtility
	{
		public static T Next<T>(this T src) where T : struct
		{
			return default(T);
		}

		public static T Previous<T>(this T src) where T : struct
		{
			return default(T);
		}

		public static IEnumerable<Enum> GetFlags(this Enum e)
		{
			return null;
		}

		public static int GetArrayIndexOf<T>(this T src) where T : struct
		{
			return 0;
		}

		public static T GetEnumByArrayIndex<T>(int arrayIndex) where T : struct
		{
			return default(T);
		}

		public static int GetLength<T>() where T : struct
		{
			return 0;
		}
	}
}
