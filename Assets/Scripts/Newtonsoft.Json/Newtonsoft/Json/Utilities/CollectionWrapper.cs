using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities
{
	internal class CollectionWrapper<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedCollection, IList, ICollection where T : notnull
	{
		private readonly IList? _list;

		private readonly ICollection<T>? _genericCollection;

		private object? _syncRoot;

		public virtual int Count => 0;

		public virtual bool IsReadOnly => false;

		private bool System_002ECollections_002EIList_002EIsFixedSize => false;

		private object System_002ECollections_002EIList_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool System_002ECollections_002EICollection_002EIsSynchronized => false;

		private object System_002ECollections_002EICollection_002ESyncRoot => null;

		public object UnderlyingCollection => null;

		public CollectionWrapper(IList list)
		{
		}

		public CollectionWrapper(ICollection<T> list)
		{
		}

		public virtual void Add(T item)
		{
		}

		public virtual void Clear()
		{
		}

		public virtual bool Contains(T item)
		{
			return false;
		}

		public virtual void CopyTo(T[] array, int arrayIndex)
		{
		}

		public virtual bool Remove(T item)
		{
			return false;
		}

		public virtual IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return 0;
		}

		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return false;
		}

		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int arrayIndex)
		{
		}

		private static void VerifyValueType(object value)
		{
		}

		private static bool IsCompatibleObject(object value)
		{
			return false;
		}
	}
}
