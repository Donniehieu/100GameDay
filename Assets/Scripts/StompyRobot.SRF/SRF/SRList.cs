using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SRF
{
	[Serializable]
	[DefaultMember("Item")]
	public class SRList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__15 : IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			public SRList<T> _003C_003E4__this;

			private int _003Ci_003E5__2;

			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CGetEnumerator_003Ed__15(int _003C_003E1__state)
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
		}

		[SerializeField]
		private T[] _buffer;

		[SerializeField]
		private int _count;

		private EqualityComparer<T> _equalityComparer;

		private ReadOnlyCollection<T> _readOnlyWrapper;

		public T[] Buffer
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private EqualityComparer<T> EqualityComparer => null;

		public int Count
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public bool IsReadOnly => false;

		public T Item
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public SRList()
		{
		}

		public SRList(int capacity)
		{
		}

		public SRList(IEnumerable<T> source)
		{
		}

		[IteratorStateMachine(typeof(SRList<>._003CGetEnumerator_003Ed__15))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public void Add(T item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Insert(int index, T item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public void AddRange(IEnumerable<T> range)
		{
		}

		public void Clear(bool clean)
		{
		}

		public void Clean()
		{
		}

		public ReadOnlyCollection<T> AsReadOnly()
		{
			return null;
		}

		private void Expand()
		{
		}

		public void Trim()
		{
		}

		public void Sort(Comparison<T> comparer)
		{
		}
	}
}
