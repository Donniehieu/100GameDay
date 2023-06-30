using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	[StructLayout(2, Pack = 1, Size = 16)]
	public struct QueryDimensionsCommand : IInputDeviceCommandInfo
	{
		[FieldOffset(0)]
		internal const int kSize = 16;

		[FieldOffset(0)]
		public InputDeviceCommand baseCommand;

		[FieldOffset(8)]
		public Vector2 outDimensions;

		public static FourCC Type => default(FourCC);

		public FourCC typeStatic => default(FourCC);

		public static QueryDimensionsCommand Create()
		{
			return default(QueryDimensionsCommand);
		}
	}
}
