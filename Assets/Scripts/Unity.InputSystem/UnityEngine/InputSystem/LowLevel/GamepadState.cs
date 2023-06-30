using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	[StructLayout(2, Pack = 1, Size = 28)]
	public struct GamepadState : IInputStateTypeInfo
	{
		[FieldOffset(0)]
		internal const string ButtonSouthShortDisplayName = "A";

		[FieldOffset(0)]
		internal const string ButtonNorthShortDisplayName = "Y";

		[FieldOffset(0)]
		internal const string ButtonWestShortDisplayName = "X";

		[FieldOffset(0)]
		internal const string ButtonEastShortDisplayName = "B";

		[FieldOffset(0)]
		[InputControl(name = "select", layout = "Button", bit = 13u, displayName = "Select")]
		[InputControl(name = "start", layout = "Button", bit = 12u, usage = "Menu", displayName = "Start")]
		[InputControl(name = "rightShoulder", layout = "Button", bit = 11u, displayName = "Right Shoulder", shortDisplayName = "RB")]
		[InputControl(name = "leftShoulder", layout = "Button", bit = 10u, displayName = "Left Shoulder", shortDisplayName = "LB")]
		[InputControl(name = "buttonWest", layout = "Button", bit = 7u, usage = "SecondaryAction", aliases = new string[] { "x", "square" }, displayName = "Button West", shortDisplayName = "X")]
		[InputControl(name = "buttonSouth", layout = "Button", bit = 6u, usages = new string[] { "PrimaryAction", "Submit" }, aliases = new string[] { "a", "cross" }, displayName = "Button South", shortDisplayName = "A")]
		[InputControl(name = "leftStickPress", layout = "Button", bit = 8u, displayName = "Left Stick Press")]
		[InputControl(name = "dpad", layout = "Dpad", usage = "Hatswitch", displayName = "D-Pad", format = "BIT", sizeInBits = 4u, bit = 0u)]
		[InputControl(name = "rightStickPress", layout = "Button", bit = 9u, displayName = "Right Stick Press")]
		[InputControl(name = "buttonEast", layout = "Button", bit = 5u, usages = new string[] { "Back", "Cancel" }, aliases = new string[] { "b", "circle" }, displayName = "Button East", shortDisplayName = "B")]
		[InputControl(name = "buttonNorth", layout = "Button", bit = 4u, aliases = new string[] { "y", "triangle" }, displayName = "Button North", shortDisplayName = "Y")]
		public uint buttons;

		[FieldOffset(4)]
		[InputControl(layout = "Stick", usage = "Primary2DMotion", processors = "stickDeadzone", displayName = "Left Stick", shortDisplayName = "LS")]
		public Vector2 leftStick;

		[FieldOffset(12)]
		[InputControl(layout = "Stick", usage = "Secondary2DMotion", processors = "stickDeadzone", displayName = "Right Stick", shortDisplayName = "RS")]
		public Vector2 rightStick;

		[FieldOffset(20)]
		[InputControl(layout = "Button", format = "FLT", usage = "SecondaryTrigger", displayName = "Left Trigger", shortDisplayName = "LT")]
		public float leftTrigger;

		[FieldOffset(24)]
		[InputControl(layout = "Button", format = "FLT", usage = "SecondaryTrigger", displayName = "Right Trigger", shortDisplayName = "RT")]
		public float rightTrigger;

		public static FourCC Format => default(FourCC);

		public FourCC format => default(FourCC);

		public GamepadState(params GamepadButton[] buttons)
		{
		}

		public GamepadState WithButton(GamepadButton button, bool value = true)
		{
			return default(GamepadState);
		}
	}
}
