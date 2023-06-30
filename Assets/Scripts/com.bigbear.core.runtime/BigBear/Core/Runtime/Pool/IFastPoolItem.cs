namespace BigBear.Core.Runtime.Pool
{
	public interface IFastPoolItem
	{
		void OnFastInstantiate();

		void OnFastDestroy();
	}
}
