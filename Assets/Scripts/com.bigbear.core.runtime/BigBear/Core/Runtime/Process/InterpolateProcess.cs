namespace BigBear.Core.Runtime.Process
{
	public class InterpolateProcess : TimedProcess
	{
		protected readonly float startValue;

		protected readonly float difference;

		public float CurrentValue => 0f;

		public InterpolateProcess(float duration, float startValue, float endValue)
			: base(0f)
		{
		}
	}
}
