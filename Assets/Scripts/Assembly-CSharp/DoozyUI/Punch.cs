using System;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class Punch
	{
		public static Vector3 DEFAULT_PUNCH_MOVE_PUNCH;

		public static Vector3 DEFAULT_PUNCH_ROTATE_PUNCH;

		public static Vector3 DEFAULT_PUNCH_SCALE_PUNCH;

		public const float DEFAULT_PUNCH_START_DELAY = 0f;

		public const float DEFAULT_PUNCH_DURATION = 0.3f;

		public const int DEFAULT_PUNCH_VIBRATO = 4;

		public const float DEFAULT_PUNCH_ELASTICITY = 0.5f;

		public PunchMove move;

		public PunchRotate rotate;

		public PunchScale scale;

		public bool Enabled => false;

		public float TotalDuration => 0f;

		public void Reset()
		{
		}

		public Punch Copy()
		{
			return null;
		}
	}
}
