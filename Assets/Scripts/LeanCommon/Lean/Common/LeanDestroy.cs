using UnityEngine;

namespace Lean.Common
{
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanCommon#LeanDestroy")]
	[AddComponentMenu("Lean/Destroy")]
	public class LeanDestroy : MonoBehaviour
	{
		public GameObject Target;

		public float Seconds;

		protected virtual void Update()
		{
		}

		public void DestroyNow()
		{
		}
	}
}
