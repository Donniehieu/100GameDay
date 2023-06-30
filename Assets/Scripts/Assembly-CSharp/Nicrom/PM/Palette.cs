using System;
using System.Collections.Generic;

namespace Nicrom.PM
{
	[Serializable]
	public class Palette
	{
		public List<CellData> cellsList;

		public string paletteName;

		public bool editPaletteName;

		public bool isColorListExpanded;

		public int elementHeight;

		public int propFieldHeight;
	}
}
