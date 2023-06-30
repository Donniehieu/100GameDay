using System;
using System.Runtime.CompilerServices;

namespace Firebase
{
	public sealed class InitializationException : Exception
	{
		public InitResult InitResult
		{
			[CompilerGenerated]
			get
			{
				return default(InitResult);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public InitializationException(InitResult result)
		{
		}

		public InitializationException(InitResult result, string message)
		{
		}

		public InitializationException(InitResult result, string message, Exception inner)
		{
		}
	}
}
