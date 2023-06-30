using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	[StructLayout(2, Pack = 1, Size = 268)]
	public struct QueryKeyNameCommand : IInputDeviceCommandInfo
	{
		[FieldOffset(0)]
		internal const int kMaxNameLength = 256;

		[FieldOffset(0)]
		internal const int kSize = 268;

		[FieldOffset(0)]
		public InputDeviceCommand baseCommand;

		[FieldOffset(8)]
		public int scanOrKeyCode;

		[FieldOffset(12)]
		public unsafe fixed byte nameBuffer[256];

		public static FourCC Type => default(FourCC);

		public FourCC typeStatic => default(FourCC);

		public string ReadKeyName()
		{
			return null;
		}

		public static QueryKeyNameCommand Create(Key key)
		{
			return default(QueryKeyNameCommand);
		}
	}
}
