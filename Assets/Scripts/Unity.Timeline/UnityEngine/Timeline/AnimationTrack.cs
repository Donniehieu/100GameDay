using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Serialization;

namespace UnityEngine.Timeline
{
	[Serializable]
	[TrackBindingType(typeof(Animator))]
	[TrackClipType(typeof(AnimationPlayableAsset), false)]
	[ExcludeFromPreset]
	public class AnimationTrack : TrackAsset, ILayerable
	{
		private static class AnimationTrackUpgrade
		{
			public static void ConvertRotationsToEuler(AnimationTrack track)
			{
			}

			public static void ConvertRootMotion(AnimationTrack track)
			{
			}

			public static void ConvertInfiniteTrack(AnimationTrack track)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_outputs_003Ed__49 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private PlayableBinding _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public AnimationTrack _003C_003E4__this;

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
			public _003Cget_outputs_003Ed__49(int _003C_003E1__state)
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

		private const string k_DefaultInfiniteClipName = "Recorded";

		private const string k_DefaultRecordableClipName = "Recorded";

		[FormerlySerializedAs("m_OpenClipPreExtrapolation")]
		[SerializeField]
		private TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation;

		[SerializeField]
		[FormerlySerializedAs("m_OpenClipPostExtrapolation")]
		private TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation;

		[SerializeField]
		[FormerlySerializedAs("m_OpenClipOffsetPosition")]
		private Vector3 m_InfiniteClipOffsetPosition;

		[FormerlySerializedAs("m_OpenClipOffsetEulerAngles")]
		[SerializeField]
		private Vector3 m_InfiniteClipOffsetEulerAngles;

		[SerializeField]
		[FormerlySerializedAs("m_OpenClipTimeOffset")]
		private double m_InfiniteClipTimeOffset;

		[FormerlySerializedAs("m_OpenClipRemoveOffset")]
		[SerializeField]
		private bool m_InfiniteClipRemoveOffset;

		[SerializeField]
		private bool m_InfiniteClipApplyFootIK;

		[SerializeField]
		[HideInInspector]
		private AnimationPlayableAsset.LoopMode mInfiniteClipLoop;

		[SerializeField]
		private MatchTargetFields m_MatchTargetFields;

		[SerializeField]
		private Vector3 m_Position;

		[SerializeField]
		private Vector3 m_EulerAngles;

		[SerializeField]
		private AvatarMask m_AvatarMask;

		[SerializeField]
		private bool m_ApplyAvatarMask;

		[SerializeField]
		private TrackOffset m_TrackOffset;

		[HideInInspector]
		[SerializeField]
		private AnimationClip m_InfiniteClip;

		private static readonly Queue<Transform> s_CachedQueue;

		[HideInInspector]
		[Obsolete("Use m_InfiniteClipOffsetEulerAngles Instead", false)]
		[SerializeField]
		private Quaternion m_OpenClipOffsetRotation;

		[HideInInspector]
		[SerializeField]
		[Obsolete("Use m_RotationEuler Instead", false)]
		private Quaternion m_Rotation;

		[Obsolete("Use m_RootTransformOffsetMode", false)]
		[SerializeField]
		[HideInInspector]
		private bool m_ApplyOffsets;

		public Vector3 position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Vector3 eulerAngles
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[Obsolete("applyOffset is deprecated. Use trackOffset instead", true)]
		public bool applyOffsets
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public TrackOffset trackOffset
		{
			get
			{
				return default(TrackOffset);
			}
			set
			{
			}
		}

		public MatchTargetFields matchTargetFields
		{
			get
			{
				return default(MatchTargetFields);
			}
			set
			{
			}
		}

		public AnimationClip infiniteClip
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal bool infiniteClipRemoveOffset
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AvatarMask avatarMask
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool applyAvatarMask
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override IEnumerable<PlayableBinding> outputs
		{
			[IteratorStateMachine(typeof(_003Cget_outputs_003Ed__49))]
			get
			{
				return null;
			}
		}

		public bool inClipMode => false;

		public Vector3 infiniteClipOffsetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion infiniteClipOffsetRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Vector3 infiniteClipOffsetEulerAngles
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		internal bool infiniteClipApplyFootIK
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal double infiniteClipTimeOffset
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public TimelineClip.ClipExtrapolation infiniteClipPreExtrapolation
		{
			get
			{
				return default(TimelineClip.ClipExtrapolation);
			}
			set
			{
			}
		}

		public TimelineClip.ClipExtrapolation infiniteClipPostExtrapolation
		{
			get
			{
				return default(TimelineClip.ClipExtrapolation);
			}
			set
			{
			}
		}

		internal AnimationPlayableAsset.LoopMode infiniteClipLoop
		{
			get
			{
				return default(AnimationPlayableAsset.LoopMode);
			}
			set
			{
			}
		}

		[Obsolete("openClipOffsetPosition has been deprecated. Use infiniteClipOffsetPosition instead. (UnityUpgradable) -> infiniteClipOffsetPosition", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Vector3 openClipOffsetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[Obsolete("openClipOffsetRotation has been deprecated. Use infiniteClipOffsetRotation instead. (UnityUpgradable) -> infiniteClipOffsetRotation", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Quaternion openClipOffsetRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("openClipOffsetEulerAngles has been deprecated. Use infiniteClipOffsetEulerAngles instead. (UnityUpgradable) -> infiniteClipOffsetEulerAngles", true)]
		public Vector3 openClipOffsetEulerAngles
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[Obsolete("openClipPreExtrapolation has been deprecated. Use infiniteClipPreExtrapolation instead. (UnityUpgradable) -> infiniteClipPreExtrapolation", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TimelineClip.ClipExtrapolation openClipPreExtrapolation
		{
			get
			{
				return default(TimelineClip.ClipExtrapolation);
			}
			set
			{
			}
		}

		[Obsolete("openClipPostExtrapolation has been deprecated. Use infiniteClipPostExtrapolation instead. (UnityUpgradable) -> infiniteClipPostExtrapolation", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TimelineClip.ClipExtrapolation openClipPostExtrapolation
		{
			get
			{
				return default(TimelineClip.ClipExtrapolation);
			}
			set
			{
			}
		}

		internal override bool CanCompileClips()
		{
			return false;
		}

		[ContextMenu("Reset Offsets")]
		private void ResetOffsets()
		{
		}

		public TimelineClip CreateClip(AnimationClip clip)
		{
			return null;
		}

		public void CreateInfiniteClip(string infiniteClipName)
		{
		}

		public TimelineClip CreateRecordableClip(string animClipName)
		{
			return null;
		}

		protected override void OnCreateClip(TimelineClip clip)
		{
		}

		protected internal override int CalculateItemsHash()
		{
			return 0;
		}

		internal void UpdateClipOffsets()
		{
		}

		private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
		{
			return default(Playable);
		}

		private Playable UnityEngine_002ETimeline_002EILayerable_002ECreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		internal override Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree)
		{
			return default(Playable);
		}

		private int GetDefaultBlendCount()
		{
			return 0;
		}

		private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset)
		{
		}

		private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot)
		{
			return default(Playable);
		}

		private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject)
		{
			return false;
		}

		private static bool UsesAbsoluteMotion(AppliedOffsetMode mode)
		{
			return false;
		}

		private bool HasController(GameObject gameObject)
		{
			return false;
		}

		internal Animator GetBinding(PlayableDirector director)
		{
			return null;
		}

		private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(AnimationLayerMixerPlayable);
		}

		private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode)
		{
			return default(Playable);
		}

		private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode)
		{
			return default(Playable);
		}

		internal override void GetEvaluationTime(out double outStart, out double outDuration)
		{
			outStart = default(double);
			outDuration = default(double);
		}

		internal override void GetSequenceTime(out double outStart, out double outDuration)
		{
			outStart = default(double);
			outDuration = default(double);
		}

		private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip)
		{
		}

		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		private void GetAnimationClips(List<AnimationClip> animClips)
		{
		}

		private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform)
		{
			return default(AppliedOffsetMode);
		}

		private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode)
		{
			return false;
		}

		private Transform GetGenericRootNode(GameObject gameObject)
		{
			return null;
		}

		internal bool AnimatesRootTransform()
		{
			return false;
		}

		private static Transform FindInHierarchyBreadthFirst(Transform t, string name)
		{
			return null;
		}

		internal override void OnUpgradeFromVersion(int oldVersion)
		{
		}
	}
}
