using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class EnableIfAttribute : Attribute
	{
		public string Condition;

		public object Value;

		[Obsolete("Use the Condition member instead.", false)]
		public string MemberName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public EnableIfAttribute(string condition)
		{
		}

		public EnableIfAttribute(string condition, object optionalValue)
		{
		}
	}
}
