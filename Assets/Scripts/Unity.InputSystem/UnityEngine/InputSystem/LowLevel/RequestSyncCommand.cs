using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	[StructLayout(2, Pack = 1, Size = 8)]
	public struct RequestSyncCommand : IInputDeviceCommandInfo
	{
		[FieldOffset(0)]
		internal const int kSize = 8;

		[FieldOffset(0)]
		public InputDeviceCommand baseCommand;

		public static FourCC Type => default(FourCC);

		public FourCC typeStatic => default(FourCC);

		public static RequestSyncCommand Create()
		{
			return default(RequestSyncCommand);
		}
	}
}
