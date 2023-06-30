using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace BigBear.Core.Runtime.Utils
{
	public class TimeUtils
	{
		private static readonly DateTime Jan1st2015;

		public static readonly string dateFormat;

		public static readonly string timeFormat;

		public static readonly int secondsPerDay;

		public static readonly int secondsPerMinute;

		public static readonly int secondsPerHour;

		public static readonly int secondPerWeek;

		private static StringBuilder strBuilder;

		private static int deltaSecondsWithServer
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static void Setup(int currentTimeServer)
		{
		}

		public static ulong ConvertToTimeInSecond(DateTime time)
		{
			return 0uL;
		}

		public static DateTime ConvertToDateTime(int timeSecond)
		{
			return default(DateTime);
		}

		public static DateTime ConvertToDateTimeLong(long timeSecond)
		{
			return default(DateTime);
		}

		public static long ConvertToTimeInSecondLong(DateTime time)
		{
			return 0L;
		}

		public static int GetCurrentTimeInSecond()
		{
			return 0;
		}

		public static long GetCurrentTimeInMilisecond()
		{
			return 0L;
		}

		public static DateTime GetCurrentDateTime()
		{
			return default(DateTime);
		}

		public static ulong GetTodayMidnightTimeInSecond()
		{
			return 0uL;
		}

		public static ulong GetMidnightTimeOfDate(DateTime date)
		{
			return 0uL;
		}

		public static string GetDateTimeFormat()
		{
			return null;
		}

		public static DateTime NextDayOfWeek(DateTime from, DayOfWeek dayOfWeek)
		{
			return default(DateTime);
		}

		public static string GetDayOfWeekName(int day)
		{
			return null;
		}

		public static string FormatTime(long timeInSeconds)
		{
			return null;
		}

		public static DateTime GetThisWeekDay(DateTime currentDate, DayOfWeek dow)
		{
			return default(DateTime);
		}

		public static DateTime GetNextWeekDay(DateTime currentDate, DayOfWeek dow)
		{
			return default(DateTime);
		}

		public static DateTime GetPreviousWeekDay(DateTime currentDate, DayOfWeek dow)
		{
			return default(DateTime);
		}

		public static DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek)
		{
			return default(DateTime);
		}
	}
}
