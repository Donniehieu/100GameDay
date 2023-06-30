using UnityEngine;

namespace Pathfinding
{
	public abstract class VersionedMonoBehaviour : MonoBehaviour, ISerializationCallbackReceiver, IVersionedMonoBehaviourInternal
	{
		[SerializeField]
		[HideInInspector]
		private int version;

		protected virtual void Awake()
		{
		}

		protected virtual void Reset()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
		}

		protected virtual int OnUpgradeSerializedData(int version, bool unityThread)
		{
			return 0;
		}

		private void Pathfinding_002EIVersionedMonoBehaviourInternal_002EUpgradeFromUnityThread()
		{
		}
	}
}
