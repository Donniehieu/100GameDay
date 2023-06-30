using UnityEngine;

namespace Lean.Common
{
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanCommon#LeanSpawn")]
	[AddComponentMenu("Lean/Spawn")]
	public class LeanSpawn : MonoBehaviour
	{
		public enum SourceType
		{
			ThisTransform = 0,
			Prefab = 1
		}

		public Transform Prefab;

		public SourceType DefaultPosition;

		public SourceType DefaultRotation;

		public void Spawn()
		{
		}

		public void Spawn(Vector3 position)
		{
		}
	}
}
