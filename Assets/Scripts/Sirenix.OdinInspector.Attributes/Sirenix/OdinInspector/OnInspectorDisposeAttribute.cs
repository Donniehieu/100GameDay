using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[HideInTables]
	[Conditional("UNITY_EDITOR")]
	[DontApplyToListElements]
	[IncludeMyAttributes]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
	public class OnInspectorDisposeAttribute : ShowInInspectorAttribute
	{
		public string Action;

		public OnInspectorDisposeAttribute()
		{
		}

		public OnInspectorDisposeAttribute(string action)
		{
		}
	}
}
