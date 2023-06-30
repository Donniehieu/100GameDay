using UnityEngine;
using UnityEngine.SceneManagement;

namespace TheraBytes.BetterUi
{
	[AddComponentMenu("Better UI/In-Game Resolution Monitor", 30)]
	[HelpURL("https://documentation.therabytes.de/better-ui/IngameResolutionMonitor.html")]
	public class IngameResolutionMonitor : MonoBehaviour
	{
		private static IngameResolutionMonitor instance;

		[SerializeField]
		private bool onlyPresentInThisScene;

		public static GameObject Create()
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		private void Update()
		{
		}
	}
}
