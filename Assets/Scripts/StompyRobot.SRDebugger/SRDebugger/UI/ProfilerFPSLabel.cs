using SRDebugger.Services;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI
{
	public class ProfilerFPSLabel : SRMonoBehaviourEx
	{
		private float _nextUpdate;

		[Import]
		private IProfilerService _profilerService;

		public float UpdateFrequency;

		[SerializeField]
		[RequiredField]
		private Text _text;

		protected override void Update()
		{
		}

		private void Refresh()
		{
		}
	}
}
