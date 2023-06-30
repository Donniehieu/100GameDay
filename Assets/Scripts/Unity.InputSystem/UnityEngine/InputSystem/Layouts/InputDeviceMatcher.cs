using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Layouts
{
	public struct InputDeviceMatcher : IEquatable<InputDeviceMatcher>
	{
		[Serializable]
		internal struct MatcherJson
		{
			public struct Capability
			{
				public string path;

				public string value;
			}

			public string @interface;

			public string[] interfaces;

			public string deviceClass;

			public string[] deviceClasses;

			public string manufacturer;

			public string[] manufacturers;

			public string product;

			public string[] products;

			public string version;

			public string[] versions;

			public Capability[] capabilities;

			public static MatcherJson FromMatcher(InputDeviceMatcher matcher)
			{
				return default(MatcherJson);
			}

			public InputDeviceMatcher ToMatcher()
			{
				return default(InputDeviceMatcher);
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_patterns_003Ed__4 : IEnumerable<KeyValuePair<string, object>>, IEnumerable, IEnumerator<KeyValuePair<string, object>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private KeyValuePair<string, object> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public InputDeviceMatcher _003C_003E4__this;

			public InputDeviceMatcher _003C_003E3___003C_003E4__this;

			private int _003Ccount_003E5__2;

			private int _003Ci_003E5__3;

			private KeyValuePair<string, object> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EObject_003E_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, object>);
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
			public _003Cget_patterns_003Ed__4(int _003C_003E1__state)
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

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, object>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CSystem_002EObject_003E_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private KeyValuePair<InternedString, object>[] m_Patterns;

		private static readonly InternedString kInterfaceKey;

		private static readonly InternedString kDeviceClassKey;

		private static readonly InternedString kManufacturerKey;

		private static readonly InternedString kProductKey;

		private static readonly InternedString kVersionKey;

		public bool empty => false;

		public IEnumerable<KeyValuePair<string, object>> patterns
		{
			[IteratorStateMachine(typeof(_003Cget_patterns_003Ed__4))]
			get
			{
				return null;
			}
		}

		public InputDeviceMatcher WithInterface(string pattern, bool supportRegex = true)
		{
			return default(InputDeviceMatcher);
		}

		public InputDeviceMatcher WithDeviceClass(string pattern, bool supportRegex = true)
		{
			return default(InputDeviceMatcher);
		}

		public InputDeviceMatcher WithManufacturer(string pattern, bool supportRegex = true)
		{
			return default(InputDeviceMatcher);
		}

		public InputDeviceMatcher WithProduct(string pattern, bool supportRegex = true)
		{
			return default(InputDeviceMatcher);
		}

		public InputDeviceMatcher WithVersion(string pattern, bool supportRegex = true)
		{
			return default(InputDeviceMatcher);
		}

		public InputDeviceMatcher WithCapability<TValue>(string path, TValue value)
		{
			return default(InputDeviceMatcher);
		}

		private InputDeviceMatcher With(InternedString key, object value, bool supportRegex = true)
		{
			return default(InputDeviceMatcher);
		}

		public float MatchPercentage(InputDeviceDescription deviceDescription)
		{
			return 0f;
		}

		private static bool MatchSingleProperty(object pattern, string value)
		{
			return false;
		}

		private static int GetNumPropertiesIn(InputDeviceDescription description)
		{
			return 0;
		}

		public static InputDeviceMatcher FromDeviceDescription(InputDeviceDescription deviceDescription)
		{
			return default(InputDeviceMatcher);
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(InputDeviceMatcher other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public static bool operator ==(InputDeviceMatcher left, InputDeviceMatcher right)
		{
			return false;
		}

		public static bool operator !=(InputDeviceMatcher left, InputDeviceMatcher right)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
