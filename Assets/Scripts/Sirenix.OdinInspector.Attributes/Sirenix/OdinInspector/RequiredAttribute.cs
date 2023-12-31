using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class RequiredAttribute : Attribute
	{
		public string ErrorMessage;

		public InfoMessageType MessageType;

		public RequiredAttribute()
		{
		}

		public RequiredAttribute(string errorMessage, InfoMessageType messageType)
		{
		}

		public RequiredAttribute(string errorMessage)
		{
		}

		public RequiredAttribute(InfoMessageType messageType)
		{
		}
	}
}
