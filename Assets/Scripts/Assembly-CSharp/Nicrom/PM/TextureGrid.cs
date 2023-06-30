using System.Collections.Generic;
using UnityEngine;

namespace Nicrom.PM
{
	public class TextureGrid : ScriptableObject
	{
		public GridColorMode gridColorMode;

		public Color gridColor;

		public List<CustomGrid> gridsList;

		public List<CustomGrid> copyList;

		public Texture2D texAtlas;

		public Texture2D originTexAtlas;

		public Vector2 originOffset;

		public Vector2Int sizeOffset;

		public bool showShortcuts;

		public int zoomSpeed;

		public int handleSize;

		public int canvasBorder;

		public int panelDefaultWidth;

		public int sidePanelWidth;

		public bool showPanel;

		public bool drawAxes;

		public bool drawGrid;

		public Vector2Int texAtlasSize;
	}
}
