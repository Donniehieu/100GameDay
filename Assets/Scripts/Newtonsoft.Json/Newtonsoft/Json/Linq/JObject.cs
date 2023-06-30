using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	[DefaultMember("Item")]
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
	{
		private class JObjectDynamicProxy : DynamicProxy<JObject>
		{
			public override bool TryGetMember(JObject instance, GetMemberBinder binder, out object? result)
			{
				result = null;
				return false;
			}

			public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value)
			{
				return false;
			}

			public override IEnumerable<string> GetDynamicMemberNames(JObject instance)
			{
				return null;
			}

			public JObjectDynamicProxy()
			{
				((DynamicProxy<>)(object)this)._002Ector();
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLoadAsync_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<JObject> _003C_003Et__builder;

			public JsonReader reader;

			public CancellationToken cancellationToken;

			public JsonLoadSettings settings;

			private JObject _003Co_003E5__2;

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

		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__63 : IEnumerator<KeyValuePair<string, JToken>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private KeyValuePair<string, JToken?> _003C_003E2__current;

			public JObject _003C_003E4__this;

			private IEnumerator<JToken> _003C_003E7__wrap1;

			private KeyValuePair<string, JToken> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, JToken>);
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
			public _003CGetEnumerator_003Ed__63(int _003C_003E1__state)
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
		}

		private readonly JPropertyKeyedCollection _properties;

		protected override IList<JToken> ChildrenTokens => null;

		public override JTokenType Type => default(JTokenType);

		public override JToken? Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public new JToken? Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private ICollection<string> System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EKeys => null;

		private ICollection<JToken?> System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EValues => null;

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EIsReadOnly => false;

		public event PropertyChangedEventHandler? PropertyChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event PropertyChangingEventHandler? PropertyChanging
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		public new static Task<JObject> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__2))]
		public new static Task<JObject> LoadAsync(JsonReader reader, JsonLoadSettings? settings, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public JObject()
		{
		}

		public JObject(JObject other)
		{
		}

		public JObject(params object[] content)
		{
		}

		public JObject(object content)
		{
		}

		internal override bool DeepEquals(JToken node)
		{
			return false;
		}

		internal override int IndexOfItem(JToken? item)
		{
			return 0;
		}

		internal override bool InsertItem(int index, JToken? item, bool skipParentCheck)
		{
			return false;
		}

		internal override void ValidateToken(JToken o, JToken? existing)
		{
		}

		internal override void MergeItem(object content, JsonMergeSettings? settings)
		{
		}

		private static bool IsNull(JToken token)
		{
			return false;
		}

		internal void InternalPropertyChanged(JProperty childProperty)
		{
		}

		internal void InternalPropertyChanging(JProperty childProperty)
		{
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public IEnumerable<JProperty> Properties()
		{
			return null;
		}

		public JProperty Property(string name)
		{
			return null;
		}

		public JProperty Property(string name, StringComparison comparison)
		{
			return null;
		}

		public JEnumerable<JToken> PropertyValues()
		{
			return default(JEnumerable<JToken>);
		}

		public new static JObject Load(JsonReader reader)
		{
			return null;
		}

		public new static JObject Load(JsonReader reader, JsonLoadSettings? settings)
		{
			return null;
		}

		public new static JObject Parse(string json)
		{
			return null;
		}

		public new static JObject Parse(string json, JsonLoadSettings? settings)
		{
			return null;
		}

		public new static JObject FromObject(object o)
		{
			return null;
		}

		public new static JObject FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		public JToken? GetValue(string? propertyName)
		{
			return null;
		}

		public JToken? GetValue(string? propertyName, StringComparison comparison)
		{
			return null;
		}

		public bool TryGetValue(string propertyName, StringComparison comparison, [NotNullWhen(true)] out JToken? value)
		{
			value = null;
			return false;
		}

		public void Add(string propertyName, JToken? value)
		{
		}

		public bool ContainsKey(string propertyName)
		{
			return false;
		}

		public bool Remove(string propertyName)
		{
			return false;
		}

		public bool TryGetValue(string propertyName, [NotNullWhen(true)] out JToken? value)
		{
			value = null;
			return false;
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EAdd(KeyValuePair<string, JToken?> item)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EClear()
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EContains(KeyValuePair<string, JToken?> item)
		{
			return false;
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002ECopyTo(KeyValuePair<string, JToken?>[] array, int arrayIndex)
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002ERemove(KeyValuePair<string, JToken?> item)
		{
			return false;
		}

		internal override int GetDeepHashCode()
		{
			return 0;
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__63))]
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			return null;
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		protected virtual void OnPropertyChanging(string propertyName)
		{
		}

		private PropertyDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetProperties()
		{
			return null;
		}

		private PropertyDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetProperties(Attribute[] attributes)
		{
			return null;
		}

		private AttributeCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetAttributes()
		{
			return null;
		}

		private string? System_002EComponentModel_002EICustomTypeDescriptor_002EGetClassName()
		{
			return null;
		}

		private string? System_002EComponentModel_002EICustomTypeDescriptor_002EGetComponentName()
		{
			return null;
		}

		private TypeConverter System_002EComponentModel_002EICustomTypeDescriptor_002EGetConverter()
		{
			return null;
		}

		private EventDescriptor? System_002EComponentModel_002EICustomTypeDescriptor_002EGetDefaultEvent()
		{
			return null;
		}

		private PropertyDescriptor? System_002EComponentModel_002EICustomTypeDescriptor_002EGetDefaultProperty()
		{
			return null;
		}

		private object System_002EComponentModel_002EICustomTypeDescriptor_002EGetEditor(Type editorBaseType)
		{
			return null;
		}

		private EventDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetEvents(Attribute[] attributes)
		{
			return null;
		}

		private EventDescriptorCollection System_002EComponentModel_002EICustomTypeDescriptor_002EGetEvents()
		{
			return null;
		}

		private object System_002EComponentModel_002EICustomTypeDescriptor_002EGetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}

		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}
	}
}
