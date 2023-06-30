using System;
using System.Collections.Generic;

namespace BigBear.Core.Runtime.Extensions
{
	public static class IListExtensions
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

		public static bool IsNullOrEmpty<T>(this List<T> list)
		{
			return false;
		}
	}
}
