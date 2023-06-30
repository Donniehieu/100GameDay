using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheraBytes.BetterUi
{
	[HelpURL("https://documentation.therabytes.de/better-ui/ResolutionMonitor.html")]
	public class ResolutionMonitor : SingletonScriptableObject<ResolutionMonitor>
	{
		[CompilerGenerated]
		private sealed class _003CGetCurrentScreenConfigurations_003Ed__39 : IEnumerable<ScreenTypeConditions>, IEnumerable, IEnumerator<ScreenTypeConditions>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private ScreenTypeConditions _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private List<ScreenTypeConditions>.Enumerator _003C_003E7__wrap1;

			private ScreenTypeConditions System_002ECollections_002EGeneric_002EIEnumerator_003CTheraBytes_002EBetterUi_002EScreenTypeConditions_003E_002ECurrent
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
			public _003CGetCurrentScreenConfigurations_003Ed__39(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<ScreenTypeConditions> System_002ECollections_002EGeneric_002EIEnumerable_003CTheraBytes_002EBetterUi_002EScreenTypeConditions_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CAllResolutionDependencies_003Ed__52 : IEnumerable<IResolutionDependency>, IEnumerable, IEnumerator<IResolutionDependency>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private IResolutionDependency _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<GameObject> _003CallObjects_003E5__2;

			private IEnumerator<GameObject> _003C_003E7__wrap2;

			private OverrideScreenProperties[] _003C_003E7__wrap3;

			private int _003C_003E7__wrap4;

			private IEnumerator<IResolutionDependency> _003C_003E7__wrap5;

			private IResolutionDependency System_002ECollections_002EGeneric_002EIEnumerator_003CTheraBytes_002EBetterUi_002EIResolutionDependency_003E_002ECurrent
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
			public _003CAllResolutionDependencies_003Ed__52(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			private void _003C_003Em__Finally3()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<IResolutionDependency> System_002ECollections_002EGeneric_002EIEnumerable_003CTheraBytes_002EBetterUi_002EIResolutionDependency_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetAllEditableObjects_003Ed__53 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private GameObject _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private GameObject[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private GameObject System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EGameObject_003E_002ECurrent
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
			public _003CGetAllEditableObjects_003Ed__53(int _003C_003E1__state)
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
			private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CIterateHierarchy_003Ed__54 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private GameObject _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private GameObject root;

			public GameObject _003C_003E3__root;

			private IEnumerator _003C_003E7__wrap1;

			private IEnumerator<GameObject> _003C_003E7__wrap2;

			private GameObject System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EGameObject_003E_002ECurrent
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
			public _003CIterateHierarchy_003Ed__54(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<GameObject> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EGameObject_003E_002EGetEnumerator()
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
		[FormerlySerializedAs("optimizedResolution")]
		private Vector2 optimizedResolutionFallback;

		[SerializeField]
		[FormerlySerializedAs("optimizedDpi")]
		private float optimizedDpiFallback;

		[SerializeField]
		private string fallbackName;

		[SerializeField]
		private StaticSizerMethod[] staticSizerMethods;

		[SerializeField]
		private DpiManager dpiManager;

		private ScreenTypeConditions currentScreenConfig;

		[SerializeField]
		private List<ScreenTypeConditions> optimizedScreens;

		private static Dictionary<string, ScreenTypeConditions> lookUpScreens;

		private static HashSet<string> screenTags;

		private static Vector2 lastScreenResolution;

		private static float lastDpi;

		private static bool isDirty;

		private static string FilePath => null;

		[Obsolete("Use 'GetOptimizedResolution()' instead.")]
		public static Vector2 OptimizedResolution
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[Obsolete("Use 'GetOptimizedDpi()' instead.")]
		public static float OptimizedDpi
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static Vector2 CurrentResolution => default(Vector2);

		public static float CurrentDpi => 0f;

		public string FallbackName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Vector2 OptimizedResolutionFallback => default(Vector2);

		public static float OptimizedDpiFallback => 0f;

		public List<ScreenTypeConditions> OptimizedScreens => null;

		public static IEnumerable<string> CurrentScreenTags => null;

		public static ScreenTypeConditions CurrentScreenConfiguration => null;

		public static bool AddScreenTag(string screenTag)
		{
			return false;
		}

		public static bool RemoveScreenTag(string screenTag)
		{
			return false;
		}

		public static void ClearScreenTags()
		{
		}

		public static ScreenTypeConditions GetConfig(string name)
		{
			return null;
		}

		public static ScreenInfo GetOpimizedScreenInfo(string name)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetCurrentScreenConfigurations_003Ed__39))]
		public static IEnumerable<ScreenTypeConditions> GetCurrentScreenConfigurations()
		{
			return null;
		}

		private void OnEnable()
		{
		}

		public static float InvokeStaticMethod(ImpactMode mode, Component caller, Vector2 optimizedResolution, Vector2 actualResolution, float optimizedDpi, float actualDpi)
		{
			return 0f;
		}

		public static void MarkDirty()
		{
		}

		public static float GetOptimizedDpi(string screenName)
		{
			return 0f;
		}

		public static Vector2 GetOptimizedResolution(string screenName)
		{
			return default(Vector2);
		}

		public static bool IsOptimizedResolution(int width, int height)
		{
			return false;
		}

		public static void Update()
		{
		}

		public static void CallResolutionChanged()
		{
		}

		public void ResolutionChanged()
		{
		}

		[IteratorStateMachine(typeof(_003CAllResolutionDependencies_003Ed__52))]
		private static IEnumerable<IResolutionDependency> AllResolutionDependencies()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetAllEditableObjects_003Ed__53))]
		private static IEnumerable<GameObject> GetAllEditableObjects()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CIterateHierarchy_003Ed__54))]
		private static IEnumerable<GameObject> IterateHierarchy(GameObject root)
		{
			return null;
		}

		private static Vector2 GetCurrentResolution()
		{
			return default(Vector2);
		}

		private float GetCurrentDpi()
		{
			return 0f;
		}

		public ResolutionMonitor()
		{
			((SingletonScriptableObject<>)(object)this)._002Ector();
		}
	}
}
