using BigBear.Core.Runtime.EventManager;
using UnityEngine;

public class HeroReviveEvent : GameEvent
{
	public Vector3 position;

	public float radius;

	public HeroReviveEvent(Vector3 pos, float r)
	{
	}
}
