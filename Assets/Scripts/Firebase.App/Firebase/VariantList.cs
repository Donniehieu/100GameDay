using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Firebase
{
	[DefaultMember("Item")]
	internal class VariantList : IDisposable, IEnumerable, IEnumerable<Variant>
	{
		public sealed class VariantListEnumerator : IEnumerator, IEnumerator<Variant>, IDisposable
		{
			private VariantList collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public Variant Current => null;

			private object global_003A_003ASystem_002ECollections_002EIEnumerator_002ECurrent => null;

			public VariantListEnumerator(VariantList collection)
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

		public bool IsFixedSize => false;

		public bool IsReadOnly => false;

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

		public int Capacity
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsSynchronized => false;

		internal VariantList(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(VariantList obj)
		{
			return default(HandleRef);
		}

		~VariantList()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public VariantList(IEnumerable c)
		{
		}

		public VariantList(IEnumerable<Variant> c)
		{
		}

		public void CopyTo(Variant[] array)
		{
		}

		public void CopyTo(Variant[] array, int arrayIndex)
		{
		}

		public void CopyTo(int index, Variant[] array, int arrayIndex, int count)
		{
		}

		public Variant[] ToArray()
		{
			return null;
		}

		private IEnumerator<Variant> global_003A_003ASystem_002ECollections_002EGeneric_002EIEnumerable_003CFirebase_002EVariant_003E_002EGetEnumerator()
		{
			return null;
		}

		private IEnumerator global_003A_003ASystem_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public VariantListEnumerator GetEnumerator()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Add(Variant x)
		{
		}

		private uint size()
		{
			return 0u;
		}

		private uint capacity()
		{
			return 0u;
		}

		private void reserve(uint n)
		{
		}

		public VariantList()
		{
		}

		public VariantList(VariantList other)
		{
		}

		public VariantList(int capacity)
		{
		}

		private Variant getitemcopy(int index)
		{
			return null;
		}

		private Variant getitem(int index)
		{
			return null;
		}

		private void setitem(int index, Variant val)
		{
		}

		public void AddRange(VariantList values)
		{
		}

		public VariantList GetRange(int index, int count)
		{
			return null;
		}

		public void Insert(int index, Variant x)
		{
		}

		public void InsertRange(int index, VariantList values)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void RemoveRange(int index, int count)
		{
		}

		public static VariantList Repeat(Variant value, int count)
		{
			return null;
		}

		public void Reverse()
		{
		}

		public void Reverse(int index, int count)
		{
		}

		public void SetRange(int index, VariantList values)
		{
		}
	}
}
