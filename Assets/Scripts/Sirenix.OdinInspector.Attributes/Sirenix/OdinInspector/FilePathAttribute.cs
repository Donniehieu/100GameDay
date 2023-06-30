using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class FilePathAttribute : Attribute
	{
		public bool AbsolutePath;

		public string Extensions;

		public string ParentFolder;

		[Obsolete("Use RequireExistingPath instead.", true)]
		public bool RequireValidPath;

		public bool RequireExistingPath;

		public bool UseBackslashes;

		[Obsolete("Add a ReadOnly attribute to the property instead.", true)]
		public bool ReadOnly
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
