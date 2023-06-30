using System.Runtime.CompilerServices;

namespace BigBear.Core.Runtime.Process
{
	public class LinearInterpolateProcess : Process
	{
		public delegate void OnTimeUpdate(float _current);

		protected float start;

		protected float end;

		protected float speed;

		protected float epsilon;

		public float Current
		{
			[CompilerGenerated]
			get
			{
				return 0f;
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

		public LinearInterpolateProcess(float start, float end, float speed, float _epsilon)
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
