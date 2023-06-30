using UnityEngine.UI;

namespace BigBear.Core.Runtime.Process
{
	public class FadeOutProcess : InterpolateProcess
	{
		private Graphic graphic;

		public FadeOutProcess(float duration, Graphic graphic)
			: base(0f, 0f, 0f)
		{
		}

		public FadeOutProcess(float duration, Graphic graphic, bool fromCurrentAlpha)
			: base(0f, 0f, 0f)
		{
		}

		public FadeOutProcess(float duration, Graphic graphic, float endAlpha)
			: base(0f, 0f, 0f)
		{
		}

		public FadeOutProcess(float duration, Graphic graphic, float startAlpha, float endAlpha)
			: base(0f, 0f, 0f)
		{
		}

		public FadeOutProcess(float duration, Graphic graphic, float endAlpha, bool fromCurrentAlpha)
			: base(0f, 0f, 0f)
		{
		}

		public override void TimeUpdated()
		{
		}
	}
}
