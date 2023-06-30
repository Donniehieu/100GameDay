using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Linq
{
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, ICollection, IList, INotifyCollectionChanged
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CReadTokenFromAsync_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public JsonReader reader;

			public CancellationToken cancellationToken;

			public JContainer _003C_003E4__this;

			public JsonLoadSettings options;

			private int _003CstartDepth_003E5__2;

			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CReadContentFromAsync_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public JsonReader reader;

			public JContainer _003C_003E4__this;

			public JsonLoadSettings settings;

			public CancellationToken cancellationToken;

			private IJsonLineInfo _003ClineInfo_003E5__2;

			private JContainer _003Cparent_003E5__3;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetDescendants_003Ed__36 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JToken _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private bool self;

			public bool _003C_003E3__self;

			public JContainer _003C_003E4__this;

			private IEnumerator<JToken> _003C_003E7__wrap1;

			private JToken _003Co_003E5__3;

			private IEnumerator<JToken> _003C_003E7__wrap3;

			private JToken System_002ECollections_002EGeneric_002EIEnumerator_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CGetDescendants_003Ed__36(int _003C_003E1__state)
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

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<JToken> System_002ECollections_002EGeneric_002EIEnumerable_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		internal ListChangedEventHandler? _listChanged;

		internal AddingNewEventHandler? _addingNew;

		internal NotifyCollectionChangedEventHandler? _collectionChanged;

		private object? _syncRoot;

		private bool _busy;

		protected abstract IList<JToken> ChildrenTokens { get; }

		public override bool HasValues => false;

		public override JToken? First => null;

		public override JToken? Last => null;

		private JToken System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIsReadOnly => false;

		private bool System_002ECollections_002EIList_002EIsFixedSize => false;

		private bool System_002ECollections_002EIList_002EIsReadOnly => false;

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

		public int Count => 0;

		private bool System_002ECollections_002EICollection_002EIsSynchronized => false;

		private object System_002ECollections_002EICollection_002ESyncRoot => null;

		private bool System_002EComponentModel_002EIBindingList_002EAllowEdit => false;

		private bool System_002EComponentModel_002EIBindingList_002EAllowNew => false;

		private bool System_002EComponentModel_002EIBindingList_002EAllowRemove => false;

		private bool System_002EComponentModel_002EIBindingList_002EIsSorted => false;

		private ListSortDirection System_002EComponentModel_002EIBindingList_002ESortDirection => default(ListSortDirection);

		private PropertyDescriptor? System_002EComponentModel_002EIBindingList_002ESortProperty => null;

		private bool System_002EComponentModel_002EIBindingList_002ESupportsChangeNotification => false;

		private bool System_002EComponentModel_002EIBindingList_002ESupportsSearching => false;

		private bool System_002EComponentModel_002EIBindingList_002ESupportsSorting => false;

		public event ListChangedEventHandler ListChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public event AddingNewEventHandler AddingNew
		{
			add
			{
			}
			remove
			{
			}
		}

		public event NotifyCollectionChangedEventHandler CollectionChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		[AsyncStateMachine(typeof(_003CReadTokenFromAsync_003Ed__0))]
		internal Task ReadTokenFromAsync(JsonReader reader, JsonLoadSettings? options, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CReadContentFromAsync_003Ed__1))]
		private Task ReadContentFromAsync(JsonReader reader, JsonLoadSettings? settings, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal JContainer()
		{
		}

		internal JContainer(JContainer other)
		{
		}

		internal void CheckReentrancy()
		{
		}

		internal virtual IList<JToken> CreateChildrenCollection()
		{
			return null;
		}

		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
		}

		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
		}

		internal bool ContentsEqual(JContainer container)
		{
			return false;
		}

		public override JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		public override IEnumerable<T?>? Values<T>()
		{
			return null;
		}

		public IEnumerable<JToken> Descendants()
		{
			return null;
		}

		public IEnumerable<JToken> DescendantsAndSelf()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetDescendants_003Ed__36))]
		internal IEnumerable<JToken> GetDescendants(bool self)
		{
			return null;
		}

		internal bool IsMultiContent([NotNullWhen(true)] object? content)
		{
			return false;
		}

		internal JToken EnsureParentToken(JToken? item, bool skipParentCheck)
		{
			return null;
		}

		internal abstract int IndexOfItem(JToken? item);

		internal virtual bool InsertItem(int index, JToken? item, bool skipParentCheck)
		{
			return false;
		}

		internal virtual void RemoveItemAt(int index)
		{
		}

		internal virtual bool RemoveItem(JToken? item)
		{
			return false;
		}

		internal virtual JToken GetItem(int index)
		{
			return null;
		}

		internal virtual void SetItem(int index, JToken? item)
		{
		}

		internal virtual void ClearItems()
		{
		}

		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
		}

		internal virtual bool ContainsItem(JToken? item)
		{
			return false;
		}

		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
		}

		internal static bool IsTokenUnchanged(JToken currentValue, JToken? newValue)
		{
			return false;
		}

		internal virtual void ValidateToken(JToken o, JToken? existing)
		{
		}

		public virtual void Add(object? content)
		{
		}

		internal bool TryAdd(object? content)
		{
			return false;
		}

		internal void AddAndSkipParentCheck(JToken token)
		{
		}

		public void AddFirst(object? content)
		{
		}

		internal bool TryAddInternal(int index, object? content, bool skipParentCheck)
		{
			return false;
		}

		internal static JToken CreateFromContent(object? content)
		{
			return null;
		}

		public JsonWriter CreateWriter()
		{
			return null;
		}

		public void ReplaceAll(object content)
		{
		}

		public void RemoveAll()
		{
		}

		internal abstract void MergeItem(object content, JsonMergeSettings? settings);

		public void Merge(object content)
		{
		}

		public void Merge(object content, JsonMergeSettings? settings)
		{
		}

		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings? options)
		{
		}

		internal void ReadContentFrom(JsonReader r, JsonLoadSettings? settings)
		{
		}

		private static JProperty? ReadProperty(JsonReader r, JsonLoadSettings? settings, IJsonLineInfo? lineInfo, JContainer parent)
		{
			return null;
		}

		internal int ContentsHashCode()
		{
			return 0;
		}

		private string System_002EComponentModel_002EITypedList_002EGetListName(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		private PropertyDescriptorCollection System_002EComponentModel_002EITypedList_002EGetItemProperties(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		private int System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIndexOf(JToken item)
		{
			return 0;
		}

		private void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EInsert(int index, JToken item)
		{
		}

		private void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemoveAt(int index)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EAdd(JToken item)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EClear()
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EContains(JToken item)
		{
			return false;
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECopyTo(JToken[] array, int arrayIndex)
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemove(JToken item)
		{
			return false;
		}

		private JToken EnsureValue(object value)
		{
			return null;
		}

		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002EClear()
		{
		}

		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return false;
		}

		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		private void System_002EComponentModel_002EIBindingList_002EAddIndex(PropertyDescriptor property)
		{
		}

		private object System_002EComponentModel_002EIBindingList_002EAddNew()
		{
			return null;
		}

		private void System_002EComponentModel_002EIBindingList_002EApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
		}

		private int System_002EComponentModel_002EIBindingList_002EFind(PropertyDescriptor property, object key)
		{
			return 0;
		}

		private void System_002EComponentModel_002EIBindingList_002ERemoveIndex(PropertyDescriptor property)
		{
		}

		private void System_002EComponentModel_002EIBindingList_002ERemoveSort()
		{
		}

		internal static void MergeEnumerableContent(JContainer target, IEnumerable content, JsonMergeSettings? settings)
		{
		}
	}
}
