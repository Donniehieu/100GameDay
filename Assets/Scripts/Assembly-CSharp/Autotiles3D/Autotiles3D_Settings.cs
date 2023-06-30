using UnityEngine;

namespace Autotiles3D
{
	public class Autotiles3D_Settings : ScriptableObject
	{
		private static Autotiles3D_Settings _settings;

		public const string SettingsPath = "Assets/Autotiles3D/Content/Autotiles3D_Settings.asset";

		public bool UseUndoAPI;

		public bool SuppressTileAmountWarning;

		public static bool IsLocked;
	}
}
