using System;
using System.Collections.Generic;
using UnityEngine;

namespace Nicrom.PM
{
	[Serializable]
	public class CellData
	{
		public List<int> uvIndex;

		public Color32 currentCellColor;

		public Color32 previousCellColor;

		public Rect gridCell;

		public bool isSelected;

		public bool highlightColorApplied;

		public bool isTexture;

		public CellData(Color32 color, Rect cell, bool tColor)
		{
		}
	}
}
