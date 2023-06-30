using System;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class DUI
	{
		public enum EventType
		{
			ButtonClick = 0
		}

		public const int MENU_PRIORITY_UIELEMENT = 1;

		public const string COMPONENT_MENU_UIELEMENT = "DoozyUI/UIElement";

		public const string GAMEOBJECT_MENU_UIELEMENT = "GameObject/DoozyUI/UIElement";

		public const int MENU_PRIORITY_UIBUTTON = 2;

		public const string COMPONENT_MENU_UIBUTTON = "DoozyUI/UIButton";

		public const string GAMEOBJECT_MENU_UIBUTTON = "GameObject/DoozyUI/UIButton";

		public const string UNCATEGORIZED_CATEGORY_NAME = "Uncategorized";

		public const string DEFAULT_ELEMENT_NAME = "~Element Name~";

		public const string DEFAULT_BUTTON_NAME = "~Button Name~";

		public const string BACK_BUTTON_NAME = "Back";

		public const string CUSTOM_NAME = "~Custom Name~";

		public const int GLOBAL_EDITOR_WIDTH = 420;

		public const int BAR_HEIGHT = 20;

		public const int MINI_BAR_HEIGHT = 18;

		public const string CANVAS_DATABASE_FILENAME = "CanvasDatabase";

		private static string _DOOZYUI_PATH;

		public const string RESOURCES_PATH_DUIDATA = "";

		public const string RESOURCES_PATH_UIELEMENTS = "DUI/UIElements/";

		public const string RESOURCES_PATH_UIBUTTONS = "DUI/UIButtons/";

		public const string RESOURCES_PATH_CANVAS_DATABASE = "DUI/Canvases/";

		public const string RESOURCES_PATH_SETTINGS = "DUI/Settings/";

		public const string SETTINGS_FILENAME = "DUISettings";

		private static DUISettings _DUISettings;

		public static string PATH => null;

		public static string RELATIVE_PATH_DUIDATA => null;

		public static string RELATIVE_PATH_UIELEMENTS => null;

		public static string RELATIVE_PATH_UIBUTTONS => null;

		public static string RELATIVE_PATH_CANVAS_DATABASE => null;

		public static string RELATIVE_PATH_SETTINGS => null;

		private static string[] GetUIButtonCategoriesFileNames => null;

		public static DUISettings DUISettings => null;

		public static T GetResource<T>(string resourcesPath, string fileName) where T : ScriptableObject
		{
			return null;
		}
	}
}
