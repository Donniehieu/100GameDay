using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Lean.Touch
{
	[AddComponentMenu("Lean/Touch/Lean Touch")]
	[DefaultExecutionOrder(-100)]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanTouch")]
	public class LeanTouch : MonoBehaviour
	{
		public const string ComponentPathPrefix = "Lean/Touch/Lean ";

		public const string HelpUrlPrefix = "https://carloswilkes.github.io/Documentation/LeanTouch#";

		public const string PlusHelpUrlPrefix = "https://carloswilkes.github.io/Documentation/LeanTouchPlus#";

		public static List<LeanTouch> Instances;

		public static List<LeanFinger> Fingers;

		public static List<LeanFinger> InactiveFingers;

		[Tooltip("This allows you to set how many seconds are required between a finger down/up for a tap to be registered.")]
		public float TapThreshold;

		public const float DefaultTapThreshold = 0.2f;

		[Tooltip("This allows you to set how many pixels of movement (relative to the ReferenceDpi) are required within the TapThreshold for a swipe to be triggered.")]
		public float SwipeThreshold;

		public const float DefaultSwipeThreshold = 100f;

		[Tooltip("This allows you to set the default DPI you want the input scaling to be based on.")]
		public int ReferenceDpi;

		public const int DefaultReferenceDpi = 200;

		[Tooltip("This allows you to set which layers your GUI is on, so it can be ignored by each finger.")]
		public LayerMask GuiLayers;

		[Tooltip("Should each finger record snapshots of their screen positions?")]
		public bool RecordFingers;

		[Tooltip("This allows you to set the amount of pixels a finger must move for another snapshot to be stored.")]
		public float RecordThreshold;

		[Tooltip("This allows you to set the maximum amount of seconds that can be recorded, 0 = unlimited.")]
		public float RecordLimit;

		[Tooltip("This allows you to simulate multi touch inputs on devices that don't support them (e.g. desktop).")]
		public bool SimulateMultiFingers;

		[Tooltip("This allows you to set which key is required to simulate multi key twisting.")]
		public KeyCode PinchTwistKey;

		[Tooltip("This allows you to set which key is required to change the pivot point of the pinch twist gesture.")]
		public KeyCode MovePivotKey;

		[Tooltip("This allows you to set which key is required to simulate multi key dragging.")]
		public KeyCode MultiDragKey;

		[Tooltip("This allows you to set which texture will be used to show the simulated fingers.")]
		public Texture2D FingerTexture;

		private static Vector2 pivot;

		private static List<RaycastResult> tempRaycastResults;

		private static List<LeanFinger> filteredFingers;

		private static PointerEventData tempPointerEventData;

		private static EventSystem tempEventSystem;

		private static LeanFinger simulatedTapFinger;

		private static HashSet<LeanFinger> missingFingers;

		private static List<LeanFinger> tempFingers;

		public static float CurrentTapThreshold => 0f;

		public static float CurrentSwipeThreshold => 0f;

		public static int CurrentReferenceDpi => 0;

		public static LayerMask CurrentGuiLayers => default(LayerMask);

		public static LeanTouch Instance => null;

		public static float ScalingFactor => 0f;

		public static float ScreenFactor => 0f;

		public static bool GuiInUse => false;

		public static event Action<LeanFinger> OnFingerDown
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

		public static event Action<LeanFinger> OnFingerUpdate
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

		public static event Action<LeanFinger> OnFingerUp
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

		public static event Action<LeanFinger> OnFingerOld
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

		public static event Action<LeanFinger> OnFingerTap
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

		public static event Action<LeanFinger> OnFingerSwipe
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

		public static event Action<List<LeanFinger>> OnGesture
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

		public static event Action<LeanFinger> OnFingerExpired
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

		public static event Action<LeanFinger> OnFingerInactive
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

		public static bool PointOverGui(Vector2 screenPosition)
		{
			return false;
		}

		public static List<RaycastResult> RaycastGui(Vector2 screenPosition)
		{
			return null;
		}

		public static List<RaycastResult> RaycastGui(Vector2 screenPosition, LayerMask layerMask)
		{
			return null;
		}

		public static List<LeanFinger> GetFingers(bool ignoreIfStartedOverGui, bool ignoreIfOverGui, int requiredFingerCount = 0)
		{
			return null;
		}

		public static void SimulateTap(Vector2 screenPosition, float pressure = 1f, int tapCount = 1)
		{
		}

		public void Clear()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		private void UpdateFingers(float deltaTime, bool poll)
		{
		}

		protected virtual void OnGUI()
		{
		}

		private void BeginFingers(float deltaTime)
		{
		}

		private void EndFingers(float deltaTime)
		{
		}

		private void PollFingers()
		{
		}

		private void UpdateEvents()
		{
		}

		private LeanFinger AddFinger(int index, Vector2 screenPosition, float pressure, bool set)
		{
			return null;
		}

		private LeanFinger FindFinger(int index)
		{
			return null;
		}

		private int FindInactiveFingerIndex(int index)
		{
			return 0;
		}
	}
}
