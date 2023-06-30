using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class OnInspectorGUIAttribute : ShowInInspectorAttribute
	{
		public string Prepend;

		public string Append;

		[Obsolete("Use the Prepend member instead.", false)]
		public string PrependMethodName;

		[Obsolete("Use the Append member instead.", false)]
		public string AppendMethodName;

		public OnInspectorGUIAttribute()
		{
		}

		public OnInspectorGUIAttribute(string action, bool append = true)
		{
		}

		public OnInspectorGUIAttribute(string prepend, string append)
		{
		}
	}
}
