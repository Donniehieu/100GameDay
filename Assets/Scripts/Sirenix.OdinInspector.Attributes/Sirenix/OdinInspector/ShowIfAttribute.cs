using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class ShowIfAttribute : Attribute
	{
		public string Condition;

		public object Value;

		public bool Animate;

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

		public ShowIfAttribute(string condition, bool animate = true)
		{
		}

		public ShowIfAttribute(string condition, object optionalValue, bool animate = true)
		{
		}
	}
}
