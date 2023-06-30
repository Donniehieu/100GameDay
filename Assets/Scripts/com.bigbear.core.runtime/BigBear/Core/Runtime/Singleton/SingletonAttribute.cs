using System;

namespace BigBear.Core.Runtime.Singleton
{
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public class SingletonAttribute : Attribute
	{
		public readonly string Name;

		public readonly bool IsDontDestroy;

		public SingletonAttribute(string _name, bool _isDontDestroy)
		{
		}

		public SingletonAttribute(string _name)
		{
		}
	}
}
