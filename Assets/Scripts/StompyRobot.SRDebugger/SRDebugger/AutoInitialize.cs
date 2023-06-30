using UnityEngine;

namespace SRDebugger
{
	public static class AutoInitialize
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		public static void OnLoadBeforeScene()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		public static void OnLoad()
		{
		}
	}
}
