using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class OnValueChangedAttribute : Attribute
	{
		public string Action;

		public bool IncludeChildren;

		public bool InvokeOnUndoRedo;

		public bool InvokeOnInitialize;

		[Obsolete("Use the Action member instead.", false)]
		public string MethodName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public OnValueChangedAttribute(string action, bool includeChildren = false)
		{
		}
	}
}
