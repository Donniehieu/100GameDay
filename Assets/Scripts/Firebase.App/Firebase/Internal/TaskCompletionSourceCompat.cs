using System;
using System.Threading.Tasks;

namespace Firebase.Internal
{
	internal static class TaskCompletionSourceCompat<T>
	{
		private static void SetExceptionInternal(TaskCompletionSource<T> tcs, AggregateException exception)
		{
		}

		public static void SetException(TaskCompletionSource<T> tcs, AggregateException exception)
		{
		}
	}
}
