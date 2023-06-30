using UnityEngine;

namespace QuickEngine.Utils
{
	public class FontAwesomeReferences : ScriptableObject
	{
		public const string RESOURCES_PATH = "Quick/Fonts/FontAwesome/";

		private static FontAwesomeReferences _instance;

		public Font FontAwesomeBrands;

		[Header("FREE")]
		public Font FontAwesomeSolid;

		public Font FontAwesomeRegular;

		[Header("PRO")]
		public Font FontAwesomeSolidPro;

		public Font FontAwesomeRegularPro;

		public Font FontAwesomeLightPro;

		public static string RELATIVE_PATH => null;

		public static FontAwesomeReferences Instance => null;
	}
}
