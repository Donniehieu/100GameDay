using BigBear.Core.Runtime.EventManager;

namespace com.bigbear.common
{
	public class HeroUpdateDataEvent : GameEvent
	{
		public int IdObject;

		public float HP;

		public float TotalHP;

		public float Energy;

		public float TotalEnergy;
	}
}
