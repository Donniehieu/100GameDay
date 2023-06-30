using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Firebase
{
	[DefaultMember("Item")]
	internal class VariantVariantMap : IDisposable, IDictionary<Variant, Variant>, ICollection<KeyValuePair<Variant, Variant>>, IEnumerable<KeyValuePair<Variant, Variant>>, IEnumerable
	{
		public sealed class VariantVariantMapEnumerator : IEnumerator, IEnumerator<KeyValuePair<Variant, Variant>>, IDisposable
		{
			private VariantVariantMap collectionRef;

			private IList<Variant> keyCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public KeyValuePair<Variant, Variant> Current => default(KeyValuePair<Variant, Variant>);

			private object global_003A_003ASystem_002ECollections_002EIEnumerator_002ECurrent => null;

			public VariantVariantMapEnumerator(VariantVariantMap collection)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			public void Dispose()
			{
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public Variant Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsReadOnly => false;

		public ICollection<Variant> Keys => null;

		public ICollection<Variant> Values => null;

		internal VariantVariantMap(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(VariantVariantMap obj)
		{
			return default(HandleRef);
		}

		~VariantVariantMap()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public bool TryGetValue(Variant key, out Variant value)
		{
			value = null;
			return false;
		}

		public void Add(KeyValuePair<Variant, Variant> item)
		{
		}

		public bool Remove(KeyValuePair<Variant, Variant> item)
		{
			return false;
		}

		public bool Contains(KeyValuePair<Variant, Variant> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<Variant, Variant>[] array)
		{
		}

		public void CopyTo(KeyValuePair<Variant, Variant>[] array, int arrayIndex)
		{
		}

		private IEnumerator<KeyValuePair<Variant, Variant>> global_003A_003ASystem_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CFirebase_002EVariant_002CFirebase_002EVariant_003E_003E_002EGetEnumerator()
		{
			return null;
		}

		private IEnumerator global_003A_003ASystem_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public VariantVariantMapEnumerator GetEnumerator()
		{
			return null;
		}

		public VariantVariantMap()
		{
		}

		public VariantVariantMap(VariantVariantMap other)
		{
		}

		private uint size()
		{
			return 0u;
		}

		public bool empty()
		{
			return false;
		}

		public void Clear()
		{
		}

		private Variant getitem(Variant key)
		{
			return null;
		}

		private void setitem(Variant key, Variant x)
		{
		}

		public bool ContainsKey(Variant key)
		{
			return false;
		}

		public void Add(Variant key, Variant value)
		{
		}

		public bool Remove(Variant key)
		{
			return false;
		}

		private IntPtr create_iterator_begin()
		{
			return (IntPtr)0;
		}

		private Variant get_next_key(IntPtr swigiterator)
		{
			return null;
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
		}
	}
}
