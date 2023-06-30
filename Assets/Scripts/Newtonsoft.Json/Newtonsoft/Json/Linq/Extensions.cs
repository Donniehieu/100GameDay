using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	public static class Extensions
	{
		[CompilerGenerated]
		private sealed class _003CValues_003Ed__11<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull, JToken where U : notnull
		{
			private int _003C_003E1__state;

			private U? _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<T> source;

			public IEnumerable<T> _003C_003E3__source;

			private object key;

			public object _003C_003E3__key;

			private IEnumerator<T> _003C_003E7__wrap1;

			private IEnumerator<JToken> _003C_003E7__wrap2;

			private U System_002ECollections_002EGeneric_002EIEnumerator_003CU_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(U);
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CValues_003Ed__11(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			private void _003C_003Em__Finally3()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<U> System_002ECollections_002EGeneric_002EIEnumerable_003CU_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CConvert_003Ed__14<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull, JToken where U : notnull
		{
			private int _003C_003E1__state;

			private U? _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<T> source;

			public IEnumerable<T> _003C_003E3__source;

			private IEnumerator<T> _003C_003E7__wrap1;

			private U System_002ECollections_002EGeneric_002EIEnumerator_003CU_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(U);
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CConvert_003Ed__14(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<U> System_002ECollections_002EGeneric_002EIEnumerable_003CU_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		public static IJEnumerable<JToken> Ancestors<T>(this IEnumerable<T> source) where T : notnull, JToken
		{
			return null;
		}

		public static IJEnumerable<JToken> AncestorsAndSelf<T>(this IEnumerable<T> source) where T : notnull, JToken
		{
			return null;
		}

		public static IJEnumerable<JToken> Descendants<T>(this IEnumerable<T> source) where T : notnull, JContainer
		{
			return null;
		}

		public static IJEnumerable<JToken> DescendantsAndSelf<T>(this IEnumerable<T> source) where T : notnull, JContainer
		{
			return null;
		}

		public static IJEnumerable<JProperty> Properties(this IEnumerable<JObject> source)
		{
			return null;
		}

		public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source, object? key)
		{
			return null;
		}

		public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source)
		{
			return null;
		}

		public static IEnumerable<U> Values<U>(this IEnumerable<JToken> source, object key) where U : notnull
		{
			return null;
		}

		public static IEnumerable<U> Values<U>(this IEnumerable<JToken> source) where U : notnull
		{
			return null;
		}

		public static U? Value<U>(this IEnumerable<JToken> value)
		{
			return default(U);
		}

		public static U Value<T, U>(this IEnumerable<T> value) where T : notnull, JToken where U : notnull
		{
			return default(U);
		}

		[IteratorStateMachine(typeof(_003CValues_003Ed__11<, >))]
		internal static IEnumerable<U> Values<T, U>(this IEnumerable<T> source, object? key) where T : notnull, JToken where U : notnull
		{
			return null;
		}

		public static IJEnumerable<JToken> Children<T>(this IEnumerable<T> source) where T : notnull, JToken
		{
			return null;
		}

		public static IEnumerable<U> Children<T, U>(this IEnumerable<T> source) where T : notnull, JToken where U : notnull
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CConvert_003Ed__14<, >))]
		internal static IEnumerable<U> Convert<T, U>(this IEnumerable<T> source) where T : notnull, JToken where U : notnull
		{
			return null;
		}

		internal static U? Convert<T, U>(this T token) where T : JToken?
		{
			return default(U);
		}

		public static IJEnumerable<JToken> AsJEnumerable(this IEnumerable<JToken> source)
		{
			return null;
		}

		public static IJEnumerable<T> AsJEnumerable<T>(this IEnumerable<T> source) where T : notnull, JToken
		{
			return null;
		}
	}
}
