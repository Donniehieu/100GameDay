using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(AudioSource))]
	[TrackClipType(typeof(AudioPlayableAsset), false)]
	public class AudioTrack : TrackAsset
	{
		[CompilerGenerated]
		private sealed class _003Cget_outputs_003Ed__4 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private PlayableBinding _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public AudioTrack _003C_003E4__this;

			private PlayableBinding System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return default(PlayableBinding);
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
			public _003Cget_outputs_003Ed__4(int _003C_003E1__state)
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

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<PlayableBinding> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EPlayables_002EPlayableBinding_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[SerializeField]
		private AudioMixerProperties m_TrackProperties;

		public override IEnumerable<PlayableBinding> outputs
		{
			[IteratorStateMachine(typeof(_003Cget_outputs_003Ed__4))]
			get
			{
				return null;
			}
		}

		public TimelineClip CreateClip(AudioClip clip)
		{
			return null;
		}

		internal override Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree)
		{
			return default(Playable);
		}

		private void OnValidate()
		{
		}
	}
}
