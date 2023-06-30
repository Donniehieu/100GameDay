using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Firebase.Platform
{
	internal sealed class FirebaseHandler
	{
		internal class ApplicationFocusChangedEventArgs : EventArgs
		{
			public bool HasFocus
			{
				[CompilerGenerated]
				get
				{
					return false;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		private static FirebaseMonoBehaviour firebaseMonoBehaviour;

		private static int tickCount;

		private static FirebaseHandler firebaseHandler;

		internal Action UpdatedEventWrapper;

		public static IFirebaseAppUtils AppUtils
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static int TickCount => 0;

		private static Dispatcher ThreadDispatcher
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsPlayMode
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal static FirebaseHandler DefaultInstance => null;

		internal event EventHandler<EventArgs> Updated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal event EventHandler<ApplicationFocusChangedEventArgs> ApplicationFocusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		static FirebaseHandler()
		{
		}

		private FirebaseHandler()
		{
		}

		internal void StartMonoBehaviour()
		{
		}

		internal void StopMonoBehaviour()
		{
		}

		public static TResult RunOnMainThread<TResult>(Func<TResult> f)
		{
			return default(TResult);
		}

		public static Task<TResult> RunOnMainThreadAsync<TResult>(Func<TResult> f)
		{
			return null;
		}

		internal bool IsMainThread()
		{
			return false;
		}

		internal static void CreatePartialOnMainThread(IFirebaseAppUtils appUtils)
		{
		}

		internal static void Create(IFirebaseAppUtils appUtils)
		{
		}

		internal void Update()
		{
		}

		internal void OnApplicationFocus(bool hasFocus)
		{
		}

		internal static void Terminate()
		{
		}

		internal static void OnMonoBehaviourDestroyed(FirebaseMonoBehaviour behaviour)
		{
		}
	}
}
