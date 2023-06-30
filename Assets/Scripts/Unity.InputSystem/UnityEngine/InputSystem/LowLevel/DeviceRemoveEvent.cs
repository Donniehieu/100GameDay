using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	[StructLayout(2, Pack = 1, Size = 20)]
	public struct DeviceRemoveEvent : IInputEventTypeInfo
	{
		[FieldOffset(0)]
		public const int Type = 1146242381;

		[FieldOffset(0)]
		public InputEvent baseEvent;

		public FourCC typeStatic => default(FourCC);

		public InputEventPtr ToEventPtr()
		{
			return default(InputEventPtr);
		}

		public static DeviceRemoveEvent Create(int deviceId, double time = -1.0)
		{
			return default(DeviceRemoveEvent);
		}
	}
}
