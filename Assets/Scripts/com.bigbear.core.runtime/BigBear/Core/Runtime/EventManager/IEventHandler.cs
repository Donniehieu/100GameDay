namespace BigBear.Core.Runtime.EventManager
{
	public interface IEventHandler
	{
		void SubscribeEvents();

		void UnsubscribeEvents();
	}
}
