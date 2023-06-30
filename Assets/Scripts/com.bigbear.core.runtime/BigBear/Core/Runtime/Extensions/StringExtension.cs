using System;

namespace BigBear.Core.Runtime.Extensions
{
	public static class StringExtension
	{
		public static bool IsNullOrWhitespace(this string str)
		{
			return false;
		}

		public static string RemoveWhitespaces(this string str)
		{
			return null;
		}

		public static string RemoveAllTypesOfWhitespaces(this string str)
		{
			return null;
		}

		public static bool IsNumeric(this string str)
		{
			return false;
		}

		public static bool ContainsNumeric(this string str)
		{
			return false;
		}

		public static bool IsNullOrEmpty(this string str)
		{
			return false;
		}

		public static string ToTitleCase(this string str)
		{
			return null;
		}

		public static string UnPascalCase(this string text)
		{
			return null;
		}

		public static string RemoveDiacritics(this string stIn)
		{
			return null;
		}

		public static char GetAccent(this string stIn)
		{
			return '\0';
		}

		public static bool IsDiacriticsed(this string stIn)
		{
			return false;
		}

		public static string FixNewLine(this string s)
		{
			return null;
		}

		public static string StripTagsRegex(this string source)
		{
			return null;
		}

		public static string StripTagsCharArray(this string source)
		{
			return null;
		}

		public static string[] Split(this string s, string separator, StringSplitOptions splitOptions = StringSplitOptions.None)
		{
			return null;
		}

		public static int OccurenceCount(this string str, string val)
		{
			return 0;
		}

		public static int NthIndexOf(this string target, string value, int n)
		{
			return 0;
		}

		public static bool Contains(this string source, string toCheck, StringComparison comp = StringComparison.Ordinal)
		{
			return false;
		}

		public static bool EndsWith(this string a, string b)
		{
			return false;
		}

		public static bool StartsWith(this string a, string b)
		{
			return false;
		}

		public static bool RegexMatch(this string a, string b)
		{
			return false;
		}
	}
}
