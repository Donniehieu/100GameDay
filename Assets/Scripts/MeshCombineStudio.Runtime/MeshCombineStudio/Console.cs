using System.Collections.Generic;
using UnityEngine;

namespace MeshCombineStudio
{
	public class Console : MonoBehaviour
	{
		public class LogEntry
		{
			public string logString;

			public string stackTrace;

			public LogType logType;

			public int commandType;

			public bool unityLog;

			public float tStamp;

			public GameObject go;

			public MeshCombiner meshCombiner;

			public LogEntry(string logString, string stackTrace, LogType logType, bool unityLog = false, int commandType = 0, GameObject go = null, MeshCombiner meshCombiner = null)
			{
			}
		}

		public static Console instance;

		public KeyCode consoleKey;

		public bool logActive;

		public bool showConsole;

		public bool showOnError;

		public bool combineAutomatic;

		private bool showLast;

		private bool setFocus;

		private GameObject selectGO;

		public List<LogEntry> logs;

		private Rect window;

		private Rect inputRect;

		private Rect logRect;

		private Rect vScrollRect;

		private string inputText;

		private float scrollPos;

		private int lines;

		private bool showUnityLog;

		private bool showInputLog;

		private MeshCombiner[] meshCombiners;

		private MeshCombiner selectedMeshCombiner;

		private void Awake()
		{
		}

		private void ReportStartup()
		{
		}

		private void FindMeshCombiners()
		{
		}

		private void ReportMeshCombiners(bool reportSelected = true)
		{
		}

		private void ReportMeshCombiner(MeshCombiner meshCombiner, bool foundText = false)
		{
		}

		public int SelectMeshCombiner(string name)
		{
			return 0;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public static void Log(string logString, int commandType = 0, GameObject go = null, MeshCombiner meshCombiner = null)
		{
		}

		private void HandleLog(string logString, string stackTrace, LogType logType)
		{
		}

		private void Update()
		{
		}

		private void SetConsoleActive(bool active)
		{
		}

		private void ExecuteCommand(string cmd)
		{
		}

		private void DirSort()
		{
		}

		private void DirSort(string name)
		{
		}

		public void SortLog(GameObject[] gos, bool showMeshInfo = false)
		{
		}

		private string GetMeshInfo(GameObject go, ref int meshCount)
		{
			return null;
		}

		private void TimeStep(string cmd)
		{
		}

		private void TimeScale(string cmd)
		{
		}

		private void Clear(LogEntry log, string cmd)
		{
		}

		private void DirAll()
		{
		}

		private void Dir()
		{
		}

		private void Components(LogEntry log)
		{
		}

		private void ShowPath(bool showLines = true)
		{
		}

		private string GetPath(GameObject go)
		{
			return null;
		}

		private void CD(LogEntry log, string name)
		{
		}

		public void SetActiveContains(string textContains, bool active)
		{
		}

		public void DirContains(string textContains)
		{
		}

		private void OnGUI()
		{
		}

		private void AnimateColor(Color col, LogEntry log, float multi)
		{
		}
	}
}
