using System.Collections.Generic;
using UnityEngine;

namespace Nicrom.PM
{
	public class PaletteModifier : MonoBehaviour
	{
		public ColorNumbering colorNumbering;

		public TextureUpdate textureUpdate;

		public List<Palette> palettesList;

		public List<CellData> cellStorage;

		public TextureGrid texGrid;

		public Color32 gradStartColor;

		public Color32 gradEndColor;

		public Color32 highlightColor;

		public bool highlightSelectedColor;

		public bool debug;

		public bool generatePaletteModifierData;

		[Range(0f, 1f)]
		public string textureName;

		public float colorBlend;

		public int gradientStart;

		public int gradientEnd;

		public int flatColorsOnObject;

		public int texPatternsOnObject;

		public int colorFieldsInInspector;

		public int flatColorsInInspector;

		public string[] toolBarTitles;

		public int selectedToolBar;
	}
}
