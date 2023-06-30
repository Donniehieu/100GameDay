using System;
using System.Runtime.CompilerServices;

namespace Cinemachine
{
	[DocumentationSorting(Level.Undoc)]
	public sealed class DocumentationSortingAttribute : Attribute
	{
		public enum Level
		{
			Undoc = 0,
			API = 1,
			UserRef = 2
		}

		public Level Category
		{
			[CompilerGenerated]
			get
			{
				return default(Level);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DocumentationSortingAttribute(Level category)
		{
		}
	}
}
