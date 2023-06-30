using System;
using System.Collections.Generic;
using System.ComponentModel;
using Sirenix.Serialization.Utilities;

namespace Sirenix.Serialization
{
	public static class FormatterLocator
	{
		private struct FormatterInfo
		{
			public Type FormatterType;

			public Type TargetType;

			public bool AskIfCanFormatTypes;

			public int Priority;
		}

		private struct FormatterLocatorInfo
		{
			public IFormatterLocator LocatorInstance;

			public int Priority;
		}

		private static readonly object LOCK;

		private static readonly Dictionary<Type, IFormatter> FormatterInstances;

		private static readonly DoubleLookupDictionary<Type, ISerializationPolicy, IFormatter> TypeFormatterMap;

		private static readonly List<FormatterLocatorInfo> FormatterLocators;

		private static readonly List<FormatterInfo> FormatterInfos;

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the new IFormatterLocator interface instead, and register your custom locator with the RegisterFormatterLocator assembly attribute.", true)]
		public static event Func<Type, IFormatter> FormatterResolve
		{
			add
			{
			}
			remove
			{
			}
		}

		static FormatterLocator()
		{
		}

		public static IFormatter<T> GetFormatter<T>(ISerializationPolicy policy)
		{
			return null;
		}

		public static IFormatter GetFormatter(Type type, ISerializationPolicy policy)
		{
			return null;
		}

		private static void LogAOTError(Type type, Exception ex)
		{
		}

		private static IEnumerable<string> GetAllPossibleMissingAOTTypes(Type type)
		{
			return null;
		}

		internal static List<IFormatter> GetAllCompatiblePredefinedFormatters(Type type, ISerializationPolicy policy)
		{
			return null;
		}

		private static IFormatter CreateFormatter(Type type, ISerializationPolicy policy)
		{
			return null;
		}

		private static IFormatter GetFormatterInstance(Type type)
		{
			return null;
		}
	}
}
