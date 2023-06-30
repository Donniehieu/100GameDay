using System;
using UnityEngine;

namespace BigBear.Core.Runtime.Utils
{
	[Serializable]
	public class Pair<T1, T2>
	{
		[SerializeField]
		private T1 _key;

		[SerializeField]
		private T2 _value;

		public T1 Key
		{
			get
			{
				return default(T1);
			}
			set
			{
			}
		}

		public T2 Value
		{
			get
			{
				return default(T2);
			}
			set
			{
			}
		}

		public Pair(T1 _key, T2 _value)
		{
		}

		public Pair()
		{
		}
	}
}
