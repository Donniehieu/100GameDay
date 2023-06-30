namespace BigBear.Core.Runtime.FSM
{
	internal enum StateActionType : byte
	{
		OnEnter = 1,
		OnExit = 2,
		OnUpdate = 3,
		OnFixUpdate = 4,
		OnDestroy = 5
	}
}
