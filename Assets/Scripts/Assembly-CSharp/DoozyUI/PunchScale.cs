using System;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class PunchScale
	{
		public bool enabled;

		public Vector3 punch;

		public float startDelay;

		public float duration;

		public int vibrato;

		public float elasticity;

		public float TotalDuration => 0f;

		public void Reset()
		{
		}

		public void UpdateValues(PunchScale s)
		{
		}

		public PunchScale Copy()
		{
			return null;
		}
	}
}
