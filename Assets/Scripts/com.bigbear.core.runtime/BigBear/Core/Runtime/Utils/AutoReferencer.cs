using UnityEngine;

namespace BigBear.Core.Runtime.Utils
{
	public class AutoReferencer<T> : MonoBehaviour where T : AutoReferencer<T>
	{
	}
}
