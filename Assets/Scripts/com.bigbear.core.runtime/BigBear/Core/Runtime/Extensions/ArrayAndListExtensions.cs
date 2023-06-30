using System;
using System.Collections.Generic;

namespace BigBear.Core.Runtime.Extensions
{
	public static class ArrayAndListExtensions
	{
		public static void Shuffle<T>(this IList<T> ts)
		{
		}

		public static T GetRandomItemInList<T>(this IList<T> itemList, int randomCountMax, Predicate<T> selectCondition)
		{
			return default(T);
		}

		public static void AddRangeNoDuplicate<T>(this IList<T> itemList, IList<T> addedList)
		{
		}

		public static void AddRangeNoDuplicate2<T>(this IList<T> itemList, IList<T> addedList)
		{
		}

		public static void AddValueToList(this List<int> itemList, int maximumListCount, bool isAddList, int value = 0)
		{
		}

		public static bool IsNullOrEmpty<T>(this IList<T> list)
		{
			return false;
		}

		public static bool IsNullOrEmpty<T>(this T[] array)
		{
			return false;
		}

		public static bool IsNullOrEmpty<TKey, TValue>(this Dictionary<TKey, TValue> dict)
		{
			return false;
		}

		public static T GetRandomElement<T>(this T[] array)
		{
			return default(T);
		}

		public static T GetRandomElement<T>(this List<T> list)
		{
			return default(T);
		}

		public static void ShuffleArray<T>(this T[] array)
		{
		}

		public static void ShuffleList<T>(this List<T> list)
		{
		}

		public static string ToString<T>(this T[] array, string separator)
		{
			return null;
		}

		public static string ToString<T>(this List<T> list, string separator)
		{
			return null;
		}

		public static string ToString<T>(this T[] array, char separator)
		{
			return null;
		}

		public static string ToString<T>(this List<T> list, char separator)
		{
			return null;
		}
	}
}
