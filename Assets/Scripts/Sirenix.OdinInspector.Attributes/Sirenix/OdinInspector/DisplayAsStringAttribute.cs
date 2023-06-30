using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class DisplayAsStringAttribute : Attribute
	{
		public bool Overflow;

		public DisplayAsStringAttribute()
		{
		}

		public DisplayAsStringAttribute(bool overflow)
		{
		}
	}
}
