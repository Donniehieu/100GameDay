using System;

namespace BigBear.Core.Runtime.Singleton
{
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public class PrefabAttribute : Attribute
	{
		public readonly string Name;

		public readonly bool Persistent;

		public PrefabAttribute(string name, bool persistent)
		{
		}

		public PrefabAttribute(string name)
		{
		}
	}
}
