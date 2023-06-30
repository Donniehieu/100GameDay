using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[NotKeyable]
	public class ControlPlayableAsset : PlayableAsset, IPropertyPreview, ITimelineClipAsset
	{
		[CompilerGenerated]
		private sealed class _003CGetControlableScripts_003Ed__39 : IEnumerable<MonoBehaviour>, IEnumerable, IEnumerator<MonoBehaviour>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private MonoBehaviour _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private GameObject root;

			public GameObject _003C_003E3__root;

			private MonoBehaviour[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private MonoBehaviour System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EMonoBehaviour_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CGetControlableScripts_003Ed__39(int _003C_003E1__state)
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
			private IEnumerator<MonoBehaviour> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EMonoBehaviour_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private const int k_MaxRandInt = 10000;

		private static readonly List<PlayableDirector> k_EmptyDirectorsList;

		private static readonly List<ParticleSystem> k_EmptyParticlesList;

		private static readonly HashSet<ParticleSystem> s_SubEmitterCollector;

		[SerializeField]
		public ExposedReference<GameObject> sourceGameObject;

		[SerializeField]
		public GameObject prefabGameObject;

		[SerializeField]
		public bool updateParticle;

		[SerializeField]
		public uint particleRandomSeed;

		[SerializeField]
		public bool updateDirector;

		[SerializeField]
		public bool updateITimeControl;

		[SerializeField]
		public bool searchHierarchy;

		[SerializeField]
		public bool active;

		[SerializeField]
		public ActivationControlPlayable.PostPlaybackState postPlayback;

		private PlayableAsset m_ControlDirectorAsset;

		private double m_Duration;

		private bool m_SupportLoop;

		private static HashSet<PlayableDirector> s_ProcessedDirectors;

		private static HashSet<GameObject> s_CreatedPrefabs;

		internal bool controllingDirectors
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal bool controllingParticles
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override double duration => 0.0;

		public ClipCaps clipCaps => default(ClipCaps);

		public void OnEnable()
		{
		}

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		private static Playable ConnectPlayablesToMixer(PlayableGraph graph, List<Playable> playables)
		{
			return default(Playable);
		}

		private void CreateActivationPlayable(GameObject root, PlayableGraph graph, List<Playable> outplayables)
		{
		}

		private void SearchHierarchyAndConnectParticleSystem(IEnumerable<ParticleSystem> particleSystems, PlayableGraph graph, List<Playable> outplayables)
		{
		}

		private void SearchHierarchyAndConnectDirector(IEnumerable<PlayableDirector> directors, PlayableGraph graph, List<Playable> outplayables, bool disableSelfReferences)
		{
		}

		private static void SearchHierarchyAndConnectControlableScripts(IEnumerable<MonoBehaviour> controlableScripts, PlayableGraph graph, List<Playable> outplayables)
		{
		}

		private static void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, int portIndex)
		{
		}

		internal IList<T> GetComponent<T>(GameObject gameObject)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetControlableScripts_003Ed__39))]
		internal static IEnumerable<MonoBehaviour> GetControlableScripts(GameObject root)
		{
			return null;
		}

		internal void UpdateDurationAndLoopFlag(IList<PlayableDirector> directors, IList<ParticleSystem> particleSystems)
		{
		}

		private IList<ParticleSystem> GetControllableParticleSystems(GameObject go)
		{
			return null;
		}

		private static void GetControllableParticleSystems(Transform t, ICollection<ParticleSystem> roots, HashSet<ParticleSystem> subEmitters)
		{
		}

		private static void CacheSubEmitters(ParticleSystem ps, HashSet<ParticleSystem> subEmitters)
		{
		}

		public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		internal static void PreviewParticles(IPropertyCollector driver, IEnumerable<ParticleSystem> particles)
		{
		}

		internal static void PreviewActivation(IPropertyCollector driver, IEnumerable<GameObject> objects)
		{
		}

		internal static void PreviewTimeControl(IPropertyCollector driver, PlayableDirector director, IEnumerable<MonoBehaviour> scripts)
		{
		}

		internal static void PreviewDirectors(IPropertyCollector driver, IEnumerable<PlayableDirector> directors)
		{
		}
	}
}
