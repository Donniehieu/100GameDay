using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector.Internal;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class TabGroupAttribute : PropertyGroupAttribute, ISubGroupProviderAttribute
	{
		[Conditional("UNITY_EDITOR")]
		public class TabSubGroupAttribute : PropertyGroupAttribute
		{
			public TabSubGroupAttribute(string groupId, float order)
				: base(null, 0f)
			{
			}
		}

		public const string DEFAULT_NAME = "_DefaultTabGroup";

		public string TabName;

		public bool UseFixedHeight;

		public bool Paddingless;

		public bool HideTabGroupIfTabGroupOnlyHasOneTab;

		public List<string> Tabs
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TabGroupAttribute(string tab, bool useFixedHeight = false, float order = 0f)
			: base(null, 0f)
		{
		}

		public TabGroupAttribute(string group, string tab, bool useFixedHeight = false, float order = 0f)
			: base(null, 0f)
		{
		}

		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		private IList<PropertyGroupAttribute> Sirenix_002EOdinInspector_002EInternal_002EISubGroupProviderAttribute_002EGetSubGroupAttributes()
		{
			return null;
		}

		private string Sirenix_002EOdinInspector_002EInternal_002EISubGroupProviderAttribute_002ERepathMemberAttribute(PropertyGroupAttribute attr)
		{
			return null;
		}
	}
}
