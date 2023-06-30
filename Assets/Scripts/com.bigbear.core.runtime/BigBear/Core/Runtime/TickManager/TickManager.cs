using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BigBear.Core.Runtime.Singleton;
using UnityEngine;

namespace BigBear.Core.Runtime.TickManager
{
	[Singleton("UpdateManager", true)]
	[DefaultExecutionOrder(-4997)]
	public class TickManager : Singleton<TickManager>
	{
		private List<int> keyList;

		public Dictionary<int, List<ITickable>> TickableDict
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

		public List<ITickable> TickableList
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

		public override void Init()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		public void AddTickable(ITickable tickable)
		{
		}

		public void RemoveTickable(ITickable tickable)
		{
		}

		public TickManager()
		{
			((Singleton<>)(object)this)._002Ector();
		}
	}
}
