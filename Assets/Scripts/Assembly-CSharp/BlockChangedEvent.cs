using BigBear.Core.Runtime.EventManager;

public class BlockChangedEvent : GameEvent
{
	public RewardType BlockType;

	public int NumberProfile;

	public BlockChangedEvent(RewardType _type, int _number)
	{
	}
}
