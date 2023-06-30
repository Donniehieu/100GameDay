using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class ErrorEventArgs : EventArgs
	{
		public object? CurrentObject
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ErrorContext ErrorContext
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ErrorEventArgs(object? currentObject, ErrorContext errorContext)
		{
		}
	}
}
