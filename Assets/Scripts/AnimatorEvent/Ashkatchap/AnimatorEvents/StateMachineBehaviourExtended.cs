using System.Diagnostics;
using UnityEngine;

namespace Ashkatchap.AnimatorEvents
{
	public abstract class StateMachineBehaviourExtended : StateMachineBehaviour
	{
		public enum State : byte
		{
			_0_NotPlaying = 0,
			_1_StartTransitioning = 1,
			_2_Updating = 2,
			_3_ExitTransitioning = 3,
			_4_ExitLastFrame = 4
		}

		private struct Group
		{
			public byte dataIndex;

			public State prevFrame;

			public State thisFrame;

			public void Advance(State newState)
			{
			}
		}

		private Group stateNow;

		private Group statePrev;

		private bool pendingInterruptToSelf;

		private bool firstUpdateDone;

		protected abstract void InitData(byte dataIndex);

		public virtual void StateUpdate(Animator animator, ref AnimatorStateInfo stateInfo, int layerIndex, State prevFrame, State thisFrame, byte stateDataIndex)
		{
		}

		public sealed override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		public sealed override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		private void OnStateExit2(Animator animator, ref AnimatorStateInfo stateInfo, int layerIndex, ref Group group)
		{
		}

		public sealed override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		private void OnStateUpdate2(Animator animator, ref AnimatorStateInfo stateInfo, int layerIndex, ref Group group)
		{
		}

		[Conditional("DEBUG_AE")]
		private static void DebugGenericUpdate(StateMachineBehaviourExtended smb, Animator animator, int layerIndex, AnimatorStateInfo stateInfo, Group group)
		{
		}
	}
}
