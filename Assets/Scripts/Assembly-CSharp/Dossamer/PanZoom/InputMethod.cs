using System;

namespace Dossamer.PanZoom
{
	[Serializable]
	public enum InputMethod
	{
		PointerHorizontal = 0,
		PointerVertical = 1,
		HorizontalAxis = 2,
		VerticalAxis = 3,
		Scrollwheel = 4,
		CustomAxis = 5,
		PinchZoom = 6,
		Null = 7
	}
}
