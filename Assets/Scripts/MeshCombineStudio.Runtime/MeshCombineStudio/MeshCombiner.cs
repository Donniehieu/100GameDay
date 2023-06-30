using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MeshCombineStudio
{
	[ExecuteInEditMode]
	public class MeshCombiner : MonoBehaviour
	{
		public enum ObjectType
		{
			Normal = 0,
			LodGroup = 1,
			LodRenderer = 2
		}

		public enum HandleComponent
		{
			Disable = 0,
			Destroy = 1
		}

		public enum ObjectCenter
		{
			BoundsCenter = 0,
			TransformPosition = 1
		}

		public enum BackFaceTriangleMode
		{
			Transform = 0,
			Box = 1,
			Direction = 2,
			EulerAngles = 3
		}

		public delegate void EventMethod(MeshCombiner meshCombiner);

		public enum RebakeLightingMode
		{
			CopyLightmapUvs = 0,
			RegenarateLightmapUvs = 1
		}

		[Serializable]
		public class SearchOptions
		{
			public enum ComponentCondition
			{
				And = 0,
				Or = 1,
				Not = 2
			}

			public enum LODGroupSearchMode
			{
				LodGroup = 0,
				LodRenderers = 1
			}

			public bool foldoutSearchParents;

			public bool foldoutSearchConditions;

			public GameObject parent;

			public GameObject[] parentGOs;

			public ObjectCenter objectCenter;

			public LODGroupSearchMode lodGroupSearchMode;

			public bool useSearchBox;

			public Bounds searchBoxBounds;

			public bool searchBoxSquare;

			public Vector3 searchBoxPivot;

			public Vector3 searchBoxSize;

			public bool useMaxBoundsFactor;

			public float maxBoundsFactor;

			public bool useVertexInputLimit;

			public int vertexInputLimit;

			public bool useLayerMask;

			public LayerMask layerMask;

			public bool useTag;

			public string tag;

			public bool useNameContains;

			public List<string> nameContainList;

			public bool onlyActive;

			public bool onlyStatic;

			public bool onlyActiveMeshRenderers;

			public bool useComponentsFilter;

			public ComponentCondition componentCondition;

			public List<string> componentNameList;

			public void GetSearchBoxBounds()
			{
			}
		}

		[Serializable]
		public class LODGroupSettings
		{
			public bool animateCrossFading;

			public LODFadeMode fadeMode;

			public LODSettings[] lodSettings;

			public LODGroupSettings(int lodParentIndex)
			{
			}

			public void CopyFromLodGroup(LODGroup lodGroup, LOD[] lods)
			{
			}

			public void CopyToLodGroup(LODGroup lodGroup, LOD[] lods)
			{
			}
		}

		[Serializable]
		public class LODSettings
		{
			public float screenRelativeTransitionHeight;

			public float fadeTransitionWidth;

			public LODSettings(float screenRelativeTransitionHeight)
			{
			}
		}

		[Serializable]
		public class LodParentHolder
		{
			public GameObject go;

			public Transform t;

			public bool found;

			public int[] lods;

			public void Init(int lodCount)
			{
			}

			public void Create(MeshCombiner meshCombiner, int lodParentIndex)
			{
			}

			public void Reset()
			{
			}
		}

		public static EventMethod onInit;

		public static List<MeshCombiner> instances;

		public MeshCombineJobManager.JobSettings jobSettings;

		public LODGroupSettings[] lodGroupsSettings;

		public ComputeShader computeDepthToArray;

		public bool useCustomInstantiatePrefab;

		public GameObject instantiatePrefab;

		public bool instantiatePrefabValid;

		public const int maxLodCount = 8;

		public string saveMeshesFolder;

		public ObjectOctree.Cell octree;

		public List<ObjectOctree.MaxCell> changedCells;

		[NonSerialized]
		public bool octreeContainsObjects;

		public bool unitySettingsFoldout;

		public SearchOptions searchOptions;

		public bool useOriginalObjectsHideFlags;

		public HideFlags orginalObjectsHideFlags;

		public CombineConditionSettings combineConditionSettings;

		public bool outputSettingsFoldout;

		public CombineMode combineMode;

		public int cellSize;

		public Vector3 cellOffset;

		public int cellCount;

		public bool removeOriginalMeshReference;

		public bool usedRemoveOriginalMeshRederences;

		public bool useVertexOutputLimit;

		public int vertexOutputLimit;

		public RebakeLightingMode rebakeLightingMode;

		public bool copyBakedLighting;

		public bool validCopyBakedLighting;

		public bool rebakeLighting;

		public bool validRebakeLighting;

		public float scaleInLightmap;

		public bool addMeshColliders;

		public PhysicMaterial physicsMaterial;

		public bool addMeshCollidersInRange;

		public Bounds addMeshCollidersBounds;

		public bool makeMeshesUnreadable;

		public bool excludeSingleMeshes;

		public bool removeTrianglesBelowSurface;

		public bool noColliders;

		public LayerMask surfaceLayerMask;

		public float maxSurfaceHeight;

		public bool removeOverlappingTriangles;

		public bool removeSamePositionTriangles;

		public bool reportFoundObjectsNotOnOverlapLayerMask;

		public GameObject overlappingCollidersGO;

		public LayerMask overlapLayerMask;

		public int voxelizeLayer;

		public int lodGroupLayer;

		public GameObject overlappingNonCombineGO;

		public bool disableOverlappingNonCombineGO;

		public bool removeBackFaceTriangles;

		public BackFaceTriangleMode backFaceTriangleMode;

		public Transform backFaceT;

		public Vector3 backFaceDirection;

		public Vector3 backFaceRotation;

		public Bounds backFaceBounds;

		public bool useExcludeBackfaceRemovalTag;

		public string excludeBackfaceRemovalTag;

		public bool weldVertices;

		public bool weldSnapVertices;

		public float weldSnapSize;

		public bool weldIncludeNormals;

		public bool jobSettingsFoldout;

		public bool runtimeSettingsFoldout;

		public bool combineInRuntime;

		public bool combineOnStart;

		public bool useCombineSwapKey;

		public KeyCode combineSwapKey;

		public HandleComponent originalMeshRenderers;

		public HandleComponent originalLODGroups;

		public bool meshSaveSettingsFoldout;

		public bool deleteFilesFromSaveFolder;

		public Vector3 oldPosition;

		public Vector3 oldScale;

		public LodParentHolder[] lodParentHolders;

		[HideInInspector]
		public List<GameObject> combinedGameObjects;

		[HideInInspector]
		public List<CachedGameObject> foundObjects;

		[HideInInspector]
		public List<CachedLodGameObject> foundLodObjects;

		[HideInInspector]
		public List<LODGroup> foundLodGroups;

		[HideInInspector]
		public List<Collider> foundColliders;

		public HashSet<LODGroup> uniqueFoundLodGroups;

		public HashSet<Mesh> unreadableMeshes;

		public HashSet<Mesh> selectImportSettingsMeshes;

		public FoundCombineConditions foundCombineConditions;

		public HashSet<MeshCombineJobManager.MeshCombineJob> meshCombineJobs;

		public int totalMeshCombineJobs;

		public int mrDisabledCount;

		public bool combined;

		public bool isCombining;

		public bool activeOriginal;

		public bool combinedActive;

		public bool drawGizmos;

		public bool drawMeshBounds;

		public int originalTotalVertices;

		public int originalTotalTriangles;

		public int newTotalVertices;

		public int newTotalTriangles;

		public int originalDrawCalls;

		public int newDrawCalls;

		public int originalTotalNormalChannels;

		public int originalTotalTangentChannels;

		public int originalTotalUvChannels;

		public int originalTotalUv2Channels;

		public int originalTotalUv3Channels;

		public int originalTotalUv4Channels;

		public int originalTotalColorChannels;

		public int newTotalNormalChannels;

		public int newTotalTangentChannels;

		public int newTotalUvChannels;

		public int newTotalUv2Channels;

		public int newTotalUv3Channels;

		public int newTotalUv4Channels;

		public int newTotalColorChannels;

		public float combineTime;

		[NonSerialized]
		public MeshCombinerData data;

		public FastList<MeshColliderAdd> addMeshCollidersList;

		private HashSet<Transform> uniqueLodObjects;

		[NonSerialized]
		private MeshCombiner thisInstance;

		private bool hasFoundFirstObject;

		private Bounds bounds;

		private Stopwatch stopwatch;

		public event EventMethod onCombiningStart
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventMethod onCombiningAbort
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventMethod onCombiningReady
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void AddMeshColliders()
		{
		}

		public void ExecuteOnCombiningReady()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Init()
		{
		}

		private void OnDisable()
		{
		}

		public void InitData()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public static MeshCombiner GetInstance(string name)
		{
			return null;
		}

		public void CopyJobSettingsToAllInstances()
		{
		}

		public void InitMeshCombineJobManager()
		{
		}

		public void CreateLodGroupsSettings()
		{
		}

		private void StartRuntime()
		{
		}

		public void DestroyCombinedObjects()
		{
		}

		public void Reset()
		{
		}

		public void AbortAndClearMeshCombineJobs(bool executeAbortEvent = true)
		{
		}

		public void ClearMeshCombineJobs(bool executeAbortEvent = true)
		{
		}

		public void AddObjects(Transform rootT, List<Transform> transforms, bool useSearchOptions, bool checkForLODGroups = true)
		{
		}

		public void AddObjectsAutomatically(bool useSearchConditions = true)
		{
		}

		public void AddFoundObjectsToOctree()
		{
		}

		public void ResetOctree()
		{
		}

		public void CalcOctreeSize(Bounds bounds)
		{
		}

		public void ApplyChanges()
		{
		}

		public void CombineAll(bool useSearchConditions = true)
		{
		}

		private void InitAndResetLodParentsCount()
		{
		}

		public void AddObjectsFromSearchParent(bool useSearchConditions)
		{
		}

		private void CheckForFoundObjectNotOnOverlapLayerMask(GameObject go)
		{
		}

		private void AddLodGroups(Transform searchParentT, LODGroup[] lodGroups, bool useSearchOptions = true)
		{
		}

		private void AddTransforms(Transform searchParentT, Transform[] transforms, bool useSearchConditions = true)
		{
		}

		private int ValidObject(Transform searchParentT, Transform t, ObjectType objectType, bool useSearchOptions, ref CachedGameObject cachedGameObject)
		{
			return 0;
		}

		public void RestoreOriginalRenderersAndLODGroups(bool onDestroy)
		{
		}

		public void SwapCombine()
		{
		}

		private void SetOriginalCollidersActive(bool active, bool onDestroy)
		{
		}

		private void ExecuteMeshFilter(bool active, CachedGameObject cachedGO)
		{
		}

		public void ExecuteHandleObjects(bool active, HandleComponent handleOriginalObjects, HandleComponent handleOriginalLodGroups, bool includeColliders = true, bool onDestroy = false)
		{
		}

		private void DrawGizmosCube(Bounds bounds, Color color)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void LogOctreeInfo()
		{
		}
	}
}
