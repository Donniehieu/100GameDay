using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeshCombineStudio
{
	[DefaultExecutionOrder(-94000000)]
	[ExecuteInEditMode]
	public class MeshCombineJobManager : MonoBehaviour
	{
		[Serializable]
		public class JobSettings
		{
			public CombineJobMode combineJobMode;

			public ThreadAmountMode threadAmountMode;

			public int combineMeshesPerFrame;

			public bool useMultiThreading;

			public bool useMainThread;

			public int customThreadAmount;

			public bool showStats;

			public void CopySettings(JobSettings source)
			{
			}

			public void ReportStatus()
			{
			}
		}

		public enum CombineJobMode
		{
			CombineAtOnce = 0,
			CombinePerFrame = 1
		}

		public enum ThreadAmountMode
		{
			AllThreads = 0,
			HalfThreads = 1,
			Custom = 2
		}

		public enum ThreadState
		{
			isFree = 0,
			isReady = 1,
			isRunning = 2,
			hasError = 3
		}

		public class MeshCombineJobsThread
		{
			public int threadId;

			public ThreadState threadState;

			public Queue<MeshCombineJob> meshCombineJobs;

			public Queue<NewMeshObject> newMeshObjectsDone;

			public MeshCombineJobsThread(int threadId)
			{
			}

			public void ExecuteJobsThread(object state)
			{
			}
		}

		public class MeshCombineJob
		{
			public MeshCombiner meshCombiner;

			public MeshObjectsHolder meshObjectsHolder;

			public Transform parent;

			public Vector3 position;

			public int startIndex;

			public int endIndex;

			public bool firstMesh;

			public bool intersectsSurface;

			public int backFaceTrianglesRemoved;

			public int trianglesRemoved;

			public bool abort;

			public string name;

			public MeshCombineJob(MeshCombiner meshCombiner, MeshObjectsHolder meshObjectsHolder, Transform parent, Vector3 position, int startIndex, int length, bool firstMesh, bool intersectsSurface)
			{
			}
		}

		public class NewMeshObject
		{
			public static FastList<Vector3> weldVertices;

			public MeshCombineJob meshCombineJob;

			public MeshCache.SubMeshCache newMeshCache;

			public bool allSkipped;

			public Vector3 newPosition;

			private byte[] vertexIsBelow;

			private const byte belowSurface = 1;

			private const byte aboveSurface = 2;

			public void Combine(MeshCombineJob meshCombineJob)
			{
			}

			private void PrintMissingArrayWarning(MeshCombiner meshCombiner, GameObject go, Mesh mesh, string text)
			{
			}

			private void HasArray<T>(ref bool hasNewArray, bool hasArray, ref T[] newArray, Array array, int vertexCount, int totalVertices, bool useDefaultValue = false, T defaultValue = default(T))
			{
			}

			private void FillArray<T>(T[] array, int offset, int length, T value)
			{
			}

			public void RemoveTrianglesBelowSurface(Transform t, MeshCombineJob meshCombineJob)
			{
			}

			public void RemoveBackFaceTriangles(BitArray backfaceRemovalExclusions)
			{
			}

			public void WeldVertices(MeshCombineJob meshCombineJob)
			{
			}

			private void ArrangeTriangles()
			{
			}

			public void CreateMesh()
			{
			}
		}

		public static MeshCombineJobManager instance;

		public JobSettings jobSettings;

		[NonSerialized]
		public FastList<NewMeshObject> newMeshObjectsPool;

		public Dictionary<Mesh, MeshCache> meshCacheDictionary;

		[NonSerialized]
		public int totalNewMeshObjects;

		public Queue<MeshCombineJob> meshCombineJobs;

		public MeshCombineJobsThread[] meshCombineJobsThreads;

		public CamGeometryCapture camGeometryCapture;

		public int cores;

		public int threadAmount;

		public int startThreadId;

		public int endThreadId;

		public bool abort;

		private MeshCache.SubMeshCache tempMeshCache;

		private Ray ray;

		private RaycastHit hitInfo;

		public static MeshCombineJobManager CreateInstance(MeshCombiner meshCombiner, GameObject instantiatePrefab)
		{
			return null;
		}

		public static void ResetMeshCache()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void Init()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void MyUpdate()
		{
		}

		public void SetJobMode(JobSettings newJobSettings)
		{
		}

		public void AddJob(MeshCombiner meshCombiner, MeshObjectsHolder meshObjectsHolder, Transform parent, Vector3 position)
		{
		}

		private void EnqueueJob(MeshCombiner meshCombiner, MeshCombineJob meshCombineJob)
		{
		}

		public int MeshIntersectsSurface(MeshCombiner meshCombiner, CachedGameObject cachedGO)
		{
			return 0;
		}

		public void AbortJobs()
		{
		}

		public void ExecuteJobs()
		{
		}

		public void CombineMeshesDone(MeshCombineJobsThread meshCombineJobThread)
		{
		}
	}
}
