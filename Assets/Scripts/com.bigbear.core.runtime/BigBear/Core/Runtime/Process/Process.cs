using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BigBear.Core.Runtime.Process
{
	public abstract class Process
	{
		public delegate void OnTerminateCallback();

		public ProcessState State
		{
			[CompilerGenerated]
			get
			{
				return default(ProcessState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<Process> Attached
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

		public event OnTerminateCallback TerminateCallback
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

		public Process()
		{
		}

		public void Start()
		{
		}

		public void Terminate()
		{
		}

		public void InvokeTerminateCallback()
		{
		}

		public void Cancel()
		{
		}

		public void Attach(Process process)
		{
		}

		public abstract void Update(float dt);

		public abstract void Pause(bool isPause);

		public abstract void OnBegin();

		public abstract void OnTerminate();
	}
}
