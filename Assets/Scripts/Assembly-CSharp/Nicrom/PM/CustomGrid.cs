using System;
using System.Collections.Generic;
using UnityEngine;

namespace Nicrom.PM
{
	[Serializable]
	public class CustomGrid
	{
		[SerializeField]
		private HandlesPos handlesPos;

		[SerializeField]
		private List<float> vLinesOnCanvasGrid;

		[SerializeField]
		private List<float> hLinesOnCanvasGrid;

		[SerializeField]
		private TextureGrid tg;

		[SerializeField]
		private Rect gridOnCanvas;

		public Vector2Int mouseInsideRectPos;

		public Color32 gridColor;

		public string gridLabel;

		public bool editGridName;

		public bool isSelected;

		public bool showGridOptions;

		public bool isSelectionLocked;

		public bool isHandleSelected;

		private bool isDragged;

		public bool isGridPosLocked;

		public bool isOverlapping;

		public int handleID;

		public List<int> vLinesOnTexGrid;

		public List<int> hLinesOnTexGrid;

		public Color32 tintColor;

		public Color32 emptySpaceColor;

		public Vector2Int gridPos;

		public int gridWidth;

		public int gridHeight;

		public int gridColumns;

		public int gridRows;

		public bool hasEmptySpace;

		public bool isTexPattern;
	}
}
