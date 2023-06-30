using System;
using System.Runtime.InteropServices;

namespace Firebase
{
	internal class FutureBase : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal FutureBase(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(FutureBase obj)
		{
			return default(HandleRef);
		}

		~FutureBase()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public FutureBase()
		{
		}

		public FutureBase(FutureBase rhs)
		{
		}

		public void Release()
		{
		}

		public FutureStatus status()
		{
			return default(FutureStatus);
		}

		public int error()
		{
			return 0;
		}

		public string error_message()
		{
			return null;
		}
	}
}
