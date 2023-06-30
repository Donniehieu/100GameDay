using System;
using System.ComponentModel;

namespace Sirenix.Serialization
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use [HideInInspector] instead - it now also excludes the member completely from becoming a property in the property tree.", false)]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class ExcludeDataFromInspectorAttribute : Attribute
	{
	}
}
