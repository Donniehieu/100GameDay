using System.Runtime.CompilerServices;

namespace BigBear.Core.Runtime.Process
{
	public class CountDownProcessPause : Process
	{
		public delegate void OnTimeUpdate(int _current);

		protected int startNumber;

		protected int endNumber;

		private float timer;

		private float pausedDuration;

		private float startPauseTime;

		private bool isPause;

		public int Current
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public event OnTimeUpdate TimeUpdateCallback
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

		public CountDownProcessPause()
		{
		}

		public CountDownProcessPause(int _startNumber, int _endNumber)
		{
		}

		public void SetInfo(int _startNumber, int _endNumber)
		{
		}

		public override void Update(float dt)
		{
		}

		public override void OnBegin()
		{
		}

		public override void OnTerminate()
		{
		}

		public virtual void TimedUpdate()
		{
		}

		public override void Pause(bool isPause)
		{
		}
	}
}
