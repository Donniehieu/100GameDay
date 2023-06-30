using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[ShowInInspector]
	[Conditional("UNITY_EDITOR")]
	[IncludeMyAttributes]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	public class ButtonGroupAttribute : PropertyGroupAttribute
	{
		public ButtonGroupAttribute(string group = "_DefaultGroup", float order = 0f)
			: base(null, 0f)
		{
		}
	}
}
