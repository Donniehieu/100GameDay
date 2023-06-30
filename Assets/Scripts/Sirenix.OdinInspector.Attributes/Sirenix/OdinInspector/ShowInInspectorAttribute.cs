using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
	[MeansImplicitUse]
	public class ShowInInspectorAttribute : Attribute
	{
	}
}
