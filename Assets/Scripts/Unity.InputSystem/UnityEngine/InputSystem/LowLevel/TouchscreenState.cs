using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	[StructLayout(2, Pack = 1, Size = 616)]
	internal struct TouchscreenState : IInputStateTypeInfo
	{
		[FieldOffset(0)]
		public const int MaxTouches = 10;

		[FieldOffset(0)]
		[InputControl(name = "press", useStateFrom = "primaryTouch/phase", layout = "TouchPress", synthetic = true, usages = new string[] { })]
		[InputControl(name = "delta", useStateFrom = "primaryTouch/delta", layout = "Delta")]
		[InputControl(name = "position", useStateFrom = "primaryTouch/position")]
		[InputControl(name = "primaryTouch/tap", usage = "PrimaryAction")]
		[InputControl(name = "primaryTouch", displayName = "Primary Touch", layout = "Touch", synthetic = true)]
		[InputControl(name = "radius", useStateFrom = "primaryTouch/radius")]
		[InputControl(name = "pressure", useStateFrom = "primaryTouch/pressure")]
		public unsafe fixed byte primaryTouchData[56];

		[FieldOffset(0)]
		internal const int kTouchDataOffset = 56;

		[FieldOffset(56)]
		[InputControl(layout = "Touch", name = "touch", displayName = "Touch", arraySize = 10)]
		public unsafe fixed byte touchData[560];

		public static FourCC Format => default(FourCC);

		public unsafe TouchState* primaryTouch => (TouchState*)unchecked((nint)null);

		public unsafe TouchState* touches => (TouchState*)unchecked((nint)null);

		public FourCC format => default(FourCC);
	}
}
