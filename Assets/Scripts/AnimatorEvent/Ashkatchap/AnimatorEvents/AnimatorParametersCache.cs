using System;
using System.Collections.Generic;
using UnityEngine;

namespace Ashkatchap.AnimatorEvents
{
	public class AnimatorParametersCache : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Serializable]
		private struct CachedParameter
		{
			public int hash;

			public AnimatorControllerParameterType type;
		}

		public AnimatorControllerParameter[] parameters;

		private readonly Dictionary<int, AnimatorControllerParameterType> parameterType;

		private List<CachedParameter> parameterTypeCache;

		private void Awake()
		{
		}

		public bool TryGetParameterType(int parameterHash, out AnimatorControllerParameterType type)
		{
			type = default(AnimatorControllerParameterType);
			return false;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
