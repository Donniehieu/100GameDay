using System;
using System.ComponentModel;

namespace Sirenix.Serialization
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class EmittedAssemblyAttribute : Attribute
	{
		[Obsolete("This attribute cannot be used in code, and is only meant to be applied to dynamically emitted assemblies.", true)]
		public EmittedAssemblyAttribute()
		{
		}
	}
}
