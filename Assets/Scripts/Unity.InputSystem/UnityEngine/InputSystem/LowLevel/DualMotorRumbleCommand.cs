using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	[StructLayout(2, Pack = 1, Size = 16)]
	internal struct DualMotorRumbleCommand : IInputDeviceCommandInfo
	{
		[FieldOffset(0)]
		internal const int kSize = 16;

		[FieldOffset(0)]
		public InputDeviceCommand baseCommand;

		[FieldOffset(8)]
		public float lowFrequencyMotorSpeed;

		[FieldOffset(12)]
		public float highFrequencyMotorSpeed;

		public static FourCC Type => default(FourCC);

		public FourCC typeStatic => default(FourCC);

		public static DualMotorRumbleCommand Create(float lowFrequency, float highFrequency)
		{
			return default(DualMotorRumbleCommand);
		}
	}
}
