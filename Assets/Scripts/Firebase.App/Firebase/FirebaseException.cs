using System;
using System.Runtime.CompilerServices;

namespace Firebase
{
	public sealed class FirebaseException : Exception
	{
		public int ErrorCode
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public FirebaseException()
		{
		}

		public FirebaseException(int errorCode)
		{
		}

		public FirebaseException(int errorCode, string message)
		{
		}

		public FirebaseException(int errorCode, string message, Exception inner)
		{
		}
	}
}
