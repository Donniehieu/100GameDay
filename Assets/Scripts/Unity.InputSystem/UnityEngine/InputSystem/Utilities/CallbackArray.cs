using System;
using System.Reflection;

namespace UnityEngine.InputSystem.Utilities
{
	[DefaultMember("Item")]
	internal struct CallbackArray<TDelegate> where TDelegate : Delegate
	{
		private bool m_CannotMutateCallbacksArray;

		private InlinedArray<TDelegate> m_Callbacks;

		private InlinedArray<TDelegate> m_CallbacksToAdd;

		private InlinedArray<TDelegate> m_CallbacksToRemove;

		public int length => 0;

		public TDelegate Item => null;

		public void Clear()
		{
		}

		public void AddCallback(TDelegate dlg)
		{
		}

		public void RemoveCallback(TDelegate dlg)
		{
		}

		public void LockForChanges()
		{
		}

		public void UnlockForChanges()
		{
		}
	}
}
