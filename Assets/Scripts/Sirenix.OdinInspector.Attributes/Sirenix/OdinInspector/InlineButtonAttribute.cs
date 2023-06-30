using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class InlineButtonAttribute : Attribute
	{
		public string Action;

		public string Label;

		public string ShowIf;

		[Obsolete("Use the Action member instead.", false)]
		public string MemberMethod
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InlineButtonAttribute(string action, string label = null)
		{
		}
	}
}
