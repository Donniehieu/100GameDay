using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour
{
	[Header("Input specs")]
	public UnityEvent changedInputToMouseAndKeyboard;

	public UnityEvent changedInputToGamepad;

	[Header("Enable inputs")]
	public bool enableJump;

	public bool enableAttack;

	public bool enableRide;

	[HideInInspector]
	public Vector2 axisInput;

	[HideInInspector]
	public Vector2 cameraInput;

	[HideInInspector]
	public bool jump;

	[HideInInspector]
	public bool jumpHold;

	[HideInInspector]
	public float zoom;

	[HideInInspector]
	public bool ride;

	[HideInInspector]
	public bool attack;

	private bool hasJumped;

	private bool skippedFrame;

	private bool isMouseAndKeyboard;

	private bool oldInput;

	private MovementActions movementActions;

	private void Awake()
	{
	}

	public void OnMove(Vector2 moveDirection)
	{
	}

	private void GetDeviceNew(InputAction.CallbackContext ctx)
	{
	}

	public void OnMove(InputAction.CallbackContext ctx)
	{
	}

	public void OnJump()
	{
	}

	public void JumpEnded()
	{
	}

	private void FixedUpdate()
	{
	}

	public void OnCamera(InputAction.CallbackContext ctx)
	{
	}

	public void OnAttack()
	{
	}

	public void AttackEnded()
	{
	}

	public void OnRide(InputAction.CallbackContext ctx)
	{
	}

	public void RideEnded(InputAction.CallbackContext ctx)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
