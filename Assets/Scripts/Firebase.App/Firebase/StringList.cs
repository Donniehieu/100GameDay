using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Firebase
{
	[DefaultMember("Item")]
	internal class StringList : IDisposable, IEnumerable, IList<string>, ICollection<string>, IEnumerable<string>
	{
		public sealed class StringListEnumerator : IEnumerator, IEnumerator<string>, IDisposable
		{
			private StringList collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public string Current => null;

			private object global_003A_003ASystem_002ECollections_002EIEnumerator_002ECurrent => null;

			public StringListEnumerator(StringList collection)
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

		public string Item
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

		internal StringList(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(StringList obj)
		{
			return default(HandleRef);
		}

		~StringList()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public StringList(IEnumerable c)
		{
		}

		public StringList(IEnumerable<string> c)
		{
		}

		public void CopyTo(string[] array)
		{
		}

		public void CopyTo(string[] array, int arrayIndex)
		{
		}

		public void CopyTo(int index, string[] array, int arrayIndex, int count)
		{
		}

		public string[] ToArray()
		{
			return null;
		}

		private IEnumerator<string> global_003A_003ASystem_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EString_003E_002EGetEnumerator()
		{
			return null;
		}

		private IEnumerator global_003A_003ASystem_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public StringListEnumerator GetEnumerator()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Add(string x)
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

		public StringList()
		{
		}

		public StringList(StringList other)
		{
		}

		public StringList(int capacity)
		{
		}

		private string getitemcopy(int index)
		{
			return null;
		}

		private string getitem(int index)
		{
			return null;
		}

		private void setitem(int index, string val)
		{
		}

		public void AddRange(StringList values)
		{
		}

		public StringList GetRange(int index, int count)
		{
			return null;
		}

		public void Insert(int index, string x)
		{
		}

		public void InsertRange(int index, StringList values)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void RemoveRange(int index, int count)
		{
		}

		public static StringList Repeat(string value, int count)
		{
			return null;
		}

		public void Reverse()
		{
		}

		public void Reverse(int index, int count)
		{
		}

		public void SetRange(int index, StringList values)
		{
		}

		public bool Contains(string value)
		{
			return false;
		}

		public int IndexOf(string value)
		{
			return 0;
		}

		public int LastIndexOf(string value)
		{
			return 0;
		}

		public bool Remove(string value)
		{
			return false;
		}
	}
}
