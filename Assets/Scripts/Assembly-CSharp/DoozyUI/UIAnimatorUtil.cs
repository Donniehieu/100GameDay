using System;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class UIAnimatorUtil
	{
		public const string UNCATEGORIZED_CATEGORY_NAME = "Uncategorized";

		public const string DEFAULT_PRESET_NAME = "DefaultPreset";

		public const string FOLDER_NAME_IN = "In/";

		public const string FOLDER_NAME_OUT = "Out/";

		public const string FOLDER_NAME_STATE = "State/";

		public const string FOLDER_NAME_LOOP = "Loop/";

		public const string FOLDER_NAME_PUNCH = "Punch/";

		public const string RESOURCES_PATH_ANIMATIONS = "DUI/Animations/";

		public const string RESOURCES_PATH_IN_ANIM_DATA = "DUI/Animations/In/";

		public const string RESOURCES_PATH_OUT_ANIM_DATA = "DUI/Animations/Out/";

		public const string RESOURCES_PATH_STATE_ANIM_DATA = "DUI/Animations/State/";

		public const string RESOURCES_PATH_LOOP_DATA = "DUI/Animations/Loop/";

		public const string RESOURCES_PATH_PUNCH_DATA = "DUI/Animations/Punch/";

		public static string RELATIVE_PATH_ANIMATIONS => null;

		public static string RELATIVE_PATH_IN_ANIM_DATA => null;

		public static string RELATIVE_PATH_OUT_ANIM_DATA => null;

		public static string RELATIVE_PATH_STATE_ANIM_DATA => null;

		public static string RELATIVE_PATH_LOOP_DATA => null;

		public static string RELATIVE_PATH_PUNCH_DATA => null;

		private static string[] GetInAnimPresetsDirectories => null;

		private static string[] GetOutAnimPresetsDirectories => null;

		private static string[] GetInAnimPresetsNamesForCategory(string presetCategory)
		{
			return null;
		}

		private static string[] GetOutAnimPresetsNamesForCategory(string presetCategory)
		{
			return null;
		}

		public static T GetResource<T>(string resourcesPath, string fileName) where T : ScriptableObject
		{
			return null;
		}

		public static Anim GetInAnim(string presetCategory, string presetName)
		{
			return null;
		}

		public static Anim GetOutAnim(string presetCategory, string presetName)
		{
			return null;
		}

		public static Anim GetStateAnim(string presetCategory, string presetName)
		{
			return null;
		}

		public static Loop GetLoop(string presetCategory, string presetName)
		{
			return null;
		}

		public static Punch GetPunch(string presetCategory, string presetName)
		{
			return null;
		}
	}
}
