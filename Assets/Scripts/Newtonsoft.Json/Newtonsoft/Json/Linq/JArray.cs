using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Linq
{
	[DefaultMember("Item")]
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CWriteToAsync_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public JsonWriter writer;

			public CancellationToken cancellationToken;

			public JArray _003C_003E4__this;

			public JsonConverter[] converters;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

			private int _003Ci_003E5__2;

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
		private struct _003CLoadAsync_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<JArray> _003C_003Et__builder;

			public JsonReader reader;

			public CancellationToken cancellationToken;

			public JsonLoadSettings settings;

			private JArray _003Ca_003E5__2;

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

		private readonly List<JToken> _values;

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

		public new JToken Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsReadOnly => false;

		[AsyncStateMachine(typeof(_003CWriteToAsync_003Ed__0))]
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		public new static Task<JArray> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__2))]
		public new static Task<JArray> LoadAsync(JsonReader reader, JsonLoadSettings? settings, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public JArray()
		{
		}

		public JArray(JArray other)
		{
		}

		public JArray(params object[] content)
		{
		}

		public JArray(object content)
		{
		}

		internal override bool DeepEquals(JToken node)
		{
			return false;
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public new static JArray Load(JsonReader reader)
		{
			return null;
		}

		public new static JArray Load(JsonReader reader, JsonLoadSettings? settings)
		{
			return null;
		}

		public new static JArray Parse(string json)
		{
			return null;
		}

		public new static JArray Parse(string json, JsonLoadSettings? settings)
		{
			return null;
		}

		public new static JArray FromObject(object o)
		{
			return null;
		}

		public new static JArray FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		internal override int IndexOfItem(JToken? item)
		{
			return 0;
		}

		internal override void MergeItem(object content, JsonMergeSettings? settings)
		{
		}

		public int IndexOf(JToken item)
		{
			return 0;
		}

		public void Insert(int index, JToken item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public IEnumerator<JToken> GetEnumerator()
		{
			return null;
		}

		public void Add(JToken item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(JToken item)
		{
			return false;
		}

		public void CopyTo(JToken[] array, int arrayIndex)
		{
		}

		public bool Remove(JToken item)
		{
			return false;
		}

		internal override int GetDeepHashCode()
		{
			return 0;
		}
	}
}
