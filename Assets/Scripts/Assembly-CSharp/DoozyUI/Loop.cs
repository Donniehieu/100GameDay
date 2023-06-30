using System;
using DG.Tweening;

namespace DoozyUI
{
	[Serializable]
	public class Loop
	{
		public enum RotateMode
		{
			Fast = 0,
			FastBeyond360 = 1,
			WorldAxisAdd = 2,
			LocalAxisAdd = 3
		}

		public enum LoopType
		{
			Restart = 0,
			Yoyo = 1,
			Incremental = 2
		}

		public bool autoStart;

		public MoveLoop move;

		public RotateLoop rotate;

		public ScaleLoop scale;

		public FadeLoop fade;

		public bool Enabled => false;

		public float TotalDuration => 0f;

		public static DG.Tweening.RotateMode GetRotateMode(RotateMode rotateMode)
		{
			return default(DG.Tweening.RotateMode);
		}

		public static RotateMode GetRotateMode(DG.Tweening.RotateMode rotateMode)
		{
			return default(RotateMode);
		}

		public static DG.Tweening.LoopType GetLoopType(LoopType loopType)
		{
			return default(DG.Tweening.LoopType);
		}

		public static LoopType GetLoopType(DG.Tweening.LoopType loopType)
		{
			return default(LoopType);
		}

		public void Reset()
		{
		}

		public Loop Copy()
		{
			return null;
		}
	}
}
