using System.Runtime.CompilerServices;

namespace BigBear.Core.Runtime.Process
{
	public class TimedProcess : Process
	{
		protected readonly float duration;

		protected float t
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected float TimePortion => 0f;

		public TimedProcess(float duration)
		{
		}

		public override void OnBegin()
		{
		}

		public override void OnTerminate()
		{
		}

		public override void Update(float dt)
		{
		}

		public virtual void TimeUpdated()
		{
		}

		public override void Pause(bool isPause)
		{
		}
	}
}
