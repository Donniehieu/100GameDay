using System.Runtime.CompilerServices;
using UnityEngine;

public class ScrollBehavior : MonoBehaviour
{
	private Vector3 startPosition;

	private Vector3 scrollStartPosition;

	private Vector3? lastDelta;

	[Tooltip("Defaults to attached Camera component or Camera.main if left null. Camera used to convert screen space to world space.")]
	[SerializeField]
	private Camera referenceCamera;

	[Tooltip("Enable/Disable horizontal scrolling")]
	[SerializeField]
	private bool isXAxisEnabled;

	[Tooltip("Enable/Disable vertical scrolling")]
	[SerializeField]
	private bool isYAxisEnabled;

	[SerializeField]
	[Tooltip("Minimum distance for user to drag pointer for scroll to be noticeable")]
	private readonly float precision;

	public bool IsScrolling
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void CheckIsScrolling()
	{
	}

	private void UpdatePosition()
	{
	}
}
