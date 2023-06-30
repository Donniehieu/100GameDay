using UnityEngine;

namespace BigBear.Core.Runtime.Singleton
{
	public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T _instance;

		public static T Instance
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public void Awake()
		{
		}

		public abstract void Init();

		private static void GetInstance()
		{
		}
	}
}
