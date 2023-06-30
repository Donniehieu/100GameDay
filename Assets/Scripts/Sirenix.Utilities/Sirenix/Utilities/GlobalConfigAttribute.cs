using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	[AttributeUsage(AttributeTargets.Class)]
	public class GlobalConfigAttribute : Attribute
	{
		private string assetPath;

		[Obsolete("It's a bit more complicated than that as it's not always possible to know the full path, so try and make due without it if you can, only using the AssetDatabase.")]
		public string FullPath => null;

		public string AssetPath => null;

		internal string AssetPathWithAssetsPrefix => null;

		internal string AssetPathWithoutAssetsPrefix => null;

		public string ResourcesPath => null;

		[Obsolete("This option is obsolete and will have no effect - a GlobalConfig will always have an asset generated now; use a POCO singleton or a ScriptableSingleton<T> instead. Asset-less config objects that are recreated every reload cause UnityEngine.Object leaks.", true)]
		public bool UseAsset
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

		public bool IsInResourcesFolder => false;

		public GlobalConfigAttribute()
		{
		}

		public GlobalConfigAttribute(string assetPath)
		{
		}
	}
}
