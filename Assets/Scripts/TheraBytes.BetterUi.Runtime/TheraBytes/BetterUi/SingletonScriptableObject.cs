using UnityEngine;

namespace TheraBytes.BetterUi
{
	public abstract class SingletonScriptableObject<T> : ScriptableObject where T : SingletonScriptableObject<T>
	{
		private static T instance;

		private static bool creatingInstance;

		public static T Instance => null;

		public static bool HasInstance => false;

		public static bool ScriptableObjectFileExists => false;

		public static T EnsureInstance()
		{
			return null;
		}

		private static string GetFilePathWithExtention(bool fullPath)
		{
			return null;
		}
	}
}
