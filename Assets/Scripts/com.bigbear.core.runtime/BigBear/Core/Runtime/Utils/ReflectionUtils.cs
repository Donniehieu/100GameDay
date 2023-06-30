using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace BigBear.Core.Runtime.Utils
{
	public static class ReflectionUtils
	{
		public static List<string> AssemblyNames
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

		public static Dictionary<string, Type> TypeCache
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

		public static Dictionary<Assembly, List<string>> NameSpaceCache
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

		public static Assembly[] Assemblies
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

		static ReflectionUtils()
		{
		}

		public static void PrintManifestResources()
		{
		}

		public static Type GetTypeByQualifiedName(string name)
		{
			return null;
		}

		public static string GetQualifiedName(string name, string @namespace = "")
		{
			return null;
		}

		public static Type GetType(string name, string @namespace = "")
		{
			return null;
		}

		public static List<string> GetNameSpaces(Assembly assembly)
		{
			return null;
		}

		public static Assembly[] GetAllAssemblies()
		{
			return null;
		}

		public static object GetSingletonInstance(Type type, string singletonName, bool singletonIsProperty, BindingFlags flags = BindingFlags.Static | BindingFlags.Public)
		{
			return null;
		}

		public static object GetSingletonProperty(Type type, string singletonName, string propertyName, bool singletonIsProperty = true, BindingFlags singletonFlags = BindingFlags.Static | BindingFlags.Public)
		{
			return null;
		}

		public static object GetSingletonField(Type type, string singletonName, string fieldName, bool singletonIsProperty = true, BindingFlags singletonFlags = BindingFlags.Static | BindingFlags.Public)
		{
			return null;
		}

		public static bool SetSingletonProperty(Type type, string singletonName, string propertyName, object value, bool singletonIsProperty = true, BindingFlags singletonFlags = BindingFlags.Static | BindingFlags.Public)
		{
			return false;
		}

		public static bool SetSingletonField(Type type, string singletonName, string fieldName, object value, bool singletonIsProperty = true, BindingFlags singletonFlags = BindingFlags.Static | BindingFlags.Public)
		{
			return false;
		}
	}
}
