using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class AnimationElement : MonoBehaviour
{
	[SerializeField]
	private bool HideStart;

	[SerializeField]
	private float durationIn;

	[SerializeField]
	private float durationOut;

	[SerializeField]
	private Ease EaseIn;

	[SerializeField]
	private Ease EaseOut;

	[SerializeField]
	private MoveDirection MoveFrom;

	private CanvasGroup canvasGroup;

	private RectTransform rt;

	private Vector2 position;

	private void Awake()
	{
	}

	public void MoveIn()
	{
	}

	public void MoveOut()
	{
	}

	public Vector2 Position(MoveDirection dir)
	{
		return default(Vector2);
	}

	public void Hide()
	{
	}
}
