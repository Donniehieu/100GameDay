using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dossamer
{
	[Serializable]
	public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
	{
		[SerializeField]
		private List<TKey> keys;

		[SerializeField]
		private List<TValue> values;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public SerializableDictionary()
		{
			((Dictionary<TKey, TValue>)(object)this)._002Ector();
		}
	}
}
