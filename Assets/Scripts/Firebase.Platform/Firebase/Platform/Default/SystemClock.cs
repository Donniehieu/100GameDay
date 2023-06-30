using System;

namespace Firebase.Platform.Default
{
	internal class SystemClock : IClockService
	{
		public static readonly IClockService Instance;

		public DateTime Now => default(DateTime);

		public DateTime UtcNow => default(DateTime);

		protected SystemClock()
		{
		}
	}
}
