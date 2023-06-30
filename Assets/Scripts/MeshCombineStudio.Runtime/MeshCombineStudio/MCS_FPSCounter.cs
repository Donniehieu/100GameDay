using UnityEngine;

namespace MeshCombineStudio
{
	public class MCS_FPSCounter : MonoBehaviour
	{
		public enum GUIType
		{
			DisplayRunning = 0,
			DisplayResults = 1,
			DisplayNothing = 2
		}

		public static MCS_FPSCounter instance;

		[Header("___ Settings ___________________________________________________________________________________________________________")]
		public float interval;

		public GUIType displayType;

		public Vector2 gradientRange;

		public Font fontRun;

		public Font fontResult;

		public Texture logo;

		public bool showLogoOnResultsScreen;

		public KeyCode showHideButton;

		public bool acceptInput;

		public bool reset;

		[Header("___ Results ___________________________________________________________________________________________________________")]
		public float currentFPS;

		public float averageFPS;

		public float minimumFPS;

		public float maximumFPS;

		private int totalFrameCount;

		private int tempFrameCount;

		private double tStamp;

		private double tStampTemp;

		private string currentFPSText;

		private string avgFPSText;

		private string minFPSText;

		private string maxFSPText;

		private GUIStyle bigStyle;

		private GUIStyle bigStyleShadow;

		private GUIStyle smallStyle;

		private GUIStyle smallStyleShadow;

		private GUIStyle smallStyleLabel;

		private GUIStyle headerStyle;

		private Rect[] rectsRun;

		private Rect[] rectsResult;

		private Gradient gradient;

		private const float line1 = 4f;

		private const float line2 = 30f;

		private const float line3 = 44f;

		private const float line4 = 58f;

		private const float labelWidth = 26f;

		private const float paddingH = 8f;

		private const float lineHeight = 22f;

		private float columnRight;

		private float columnLeft;

		private Color fontShadow;

		private Color label;

		private Color colorCurrent;

		private Color colorAvg;

		private const string resultHeader = "BENCHMARK RESULTS";

		private const string resultLabelAvg = "AVERAGE FPS:";

		private const string resultLabelMin = "MINIMUM FPS:";

		private const string resultLabelMax = "MAXIMUM FPS:";

		private GUIContent resultHeaderGUI;

		private GUIContent reslutLabelAvgGUI;

		private GUIContent avgTextGUI;

		private GUIContent instructions;

		private const string runLabelAvg = "Avg:";

		private const string runLabelMin = "Min:";

		private const string runLabelMax = "Max:";

		private Vector2 screenSize;

		private GUIType oldDisplayType;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnGUI()
		{
		}

		private void SetRectsRun()
		{
		}

		private void SetRectsResult()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void StartBenchmark()
		{
		}

		public void StopBenchmark()
		{
		}

		private void GetFPS()
		{
		}

		public void Reset()
		{
		}

		private Color EvaluateGradient(float f)
		{
			return default(Color);
		}
	}
}
