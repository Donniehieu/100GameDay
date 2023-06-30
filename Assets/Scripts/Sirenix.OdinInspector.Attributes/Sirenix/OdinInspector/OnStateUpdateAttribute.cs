using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[HideInTables]
	[Conditional("UNITY_EDITOR")]
	[IncludeMyAttributes]
	public sealed class OnStateUpdateAttribute : Attribute
	{
		public string Action;

		public OnStateUpdateAttribute(string action)
		{
		}
	}
}
