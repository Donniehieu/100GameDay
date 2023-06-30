using System;

namespace DoozyUI
{
	[Serializable]
	public class Anim
	{
		public enum AnimationType
		{
			In = 0,
			Out = 1,
			State = 2
		}

		public AnimationType animationType;

		public Move move;

		public Rotate rotate;

		public Scale scale;

		public Fade fade;

		public bool Enabled => false;

		public float TotalDuration => 0f;

		public float StartDelay => 0f;

		public static AnimationType Reverse(AnimationType animationType)
		{
			return default(AnimationType);
		}

		public Anim(AnimationType aType)
		{
		}

		public void Reset(AnimationType aType)
		{
		}

		public void UpdateValues(Anim a)
		{
		}

		public Anim Copy()
		{
			return null;
		}

		public Anim Reverse()
		{
			return null;
		}
	}
}
