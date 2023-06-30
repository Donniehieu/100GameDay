using System;
using System.Collections.Generic;

namespace BigBear.Core.Runtime.Utils
{
	public class GameHelper
	{
		[Serializable]
		private class Wrapper<T>
		{
			public List<T> Items;
		}

		public static List<string> MixStringList(List<string> strList)
		{
			return null;
		}

		public static List<string> MixTwoListString(List<string> prefix, List<string> suffixes)
		{
			return null;
		}

		public static float Remap(float _value, float _from1, float _to1, float _from2, float _to2)
		{
			return 0f;
		}

		public static string TrimEnd(string source, string value)
		{
			return null;
		}

		public static List<T> MixElementList<T>(List<T> param)
		{
			return null;
		}

		public static List<T> FromJson<T>(string json)
		{
			return null;
		}

		public static string ToJson<T>(List<T> array)
		{
			return null;
		}

		public static string ToJson<T>(List<T> array, bool prettyPrint)
		{
			return null;
		}
	}
}
