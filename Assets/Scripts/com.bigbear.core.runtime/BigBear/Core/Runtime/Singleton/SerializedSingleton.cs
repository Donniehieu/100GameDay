using Sirenix.OdinInspector;

namespace BigBear.Core.Runtime.Singleton
{
	public abstract class SerializedSingleton<T> : SerializedMonoBehaviour where T : SerializedMonoBehaviour
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
