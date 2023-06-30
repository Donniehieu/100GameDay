using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	[StructLayout(2, Pack = 1, Size = 12)]
	internal struct UseWindowsGamingInputCommand : IInputDeviceCommandInfo
	{
		[FieldOffset(0)]
		internal const int kSize = 9;

		[FieldOffset(0)]
		public InputDeviceCommand baseCommand;

		[FieldOffset(8)]
		public byte enable;

		public static FourCC Type => default(FourCC);

		public FourCC typeStatic => default(FourCC);

		public static UseWindowsGamingInputCommand Create(bool enable)
		{
			return default(UseWindowsGamingInputCommand);
		}
	}
}
