using System;
using SRF;
using UnityEngine;

namespace SRDebugger
{
	[Obsolete("No longer required, use Automatic initialization mode or call SRDebug.Init() manually.")]
	[AddComponentMenu(null)]
	public class SRDebuggerInit : SRMonoBehaviourEx
	{
		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}
	}
}
