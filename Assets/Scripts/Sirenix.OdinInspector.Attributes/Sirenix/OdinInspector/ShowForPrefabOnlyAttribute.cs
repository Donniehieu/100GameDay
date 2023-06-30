using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Obsolete("Use HideInPrefabInstance or HideInPrefabAsset instead.", false)]
	public class ShowForPrefabOnlyAttribute : Attribute
	{
	}
}
