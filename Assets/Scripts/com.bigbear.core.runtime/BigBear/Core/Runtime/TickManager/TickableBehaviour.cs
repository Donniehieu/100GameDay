using UnityEngine;

namespace BigBear.Core.Runtime.TickManager
{
	public class TickableBehaviour : MonoBehaviour, ITickable
	{
		protected bool isAdded;

		private int listIndex;

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public virtual void OnTickableDisabled()
		{
		}

		public virtual void OnTickableEnabled()
		{
		}

		public virtual void OnTickableUpdated(float dt)
		{
		}

		public virtual void OnTickableFixedUpdated(float dt)
		{
		}

		public virtual int GetId()
		{
			return 0;
		}

		public void SetListIndex(int index)
		{
		}

		public int GetListIndex()
		{
			return 0;
		}
	}
}
