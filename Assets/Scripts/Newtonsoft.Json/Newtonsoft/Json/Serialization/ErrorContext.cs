using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class ErrorContext
	{
		internal bool Traced
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Exception Error
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public object? OriginalObject
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public object? Member
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string Path
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool Handled
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal ErrorContext(object? originalObject, object? member, string path, Exception error)
		{
		}
	}
}
