using System;
using System.Runtime.InteropServices;

namespace Firebase
{
	internal sealed class AppOptionsInternal : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwn;

		public Uri DatabaseUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string AppId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ApiKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string MessageSenderId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string StorageBucket
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ProjectId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PackageName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal AppOptionsInternal(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(AppOptionsInternal obj)
		{
			return default(HandleRef);
		}

		~AppOptionsInternal()
		{
		}

		public void Dispose()
		{
		}

		public void Dispose(bool disposing)
		{
		}

		internal AppOptionsInternal()
		{
		}

		internal void SetDatabaseUrlInternal(string url)
		{
		}

		internal string GetDatabaseUrlInternal()
		{
			return null;
		}

		internal static AppOptionsInternal LoadFromJsonConfig(string config, AppOptionsInternal options)
		{
			return null;
		}

		internal static AppOptionsInternal LoadFromJsonConfig(string config)
		{
			return null;
		}
	}
}
