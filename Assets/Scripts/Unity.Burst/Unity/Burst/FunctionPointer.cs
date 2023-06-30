using System;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Burst
{
	public readonly struct FunctionPointer<T> : IFunctionPointer
	{
		[NativeDisableUnsafePtrRestriction]
		private readonly IntPtr _ptr;

		public IntPtr Value => (IntPtr)0;

		public T Invoke => default(T);

		public bool IsCreated => false;

		public FunctionPointer(IntPtr ptr)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckIsCreated()
		{
		}

		private IFunctionPointer Unity_002EBurst_002EIFunctionPointer_002EFromIntPtr(IntPtr ptr)
		{
			return null;
		}
	}
}
