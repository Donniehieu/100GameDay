using UnityEngine;

public class EventOnClickBehavior : MonoBehaviour
{
	public delegate void Del(GameObject obj);

	public static Del handler;

	private void OnMouseDown()
	{
	}
}
