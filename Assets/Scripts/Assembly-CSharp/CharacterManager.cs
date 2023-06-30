using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(Rigidbody))]
public class CharacterManager : MonoBehaviour
{
	[Tooltip("Layers where the player can stand on")]
	[SerializeField]
	[Header("Movement specifics")]
	private LayerMask groundMask;

	[Tooltip("Base player speed")]
	public float movementSpeed;

	[Range(0.01f, 0.99f)]
	[Tooltip("Minimum input value to trigger movement")]
	public float movementThrashold;

	[Tooltip("Speed up multiplier")]
	[Space(10f)]
	public float dampSpeedUp;

	[Tooltip("Speed down multiplier")]
	public float dampSpeedDown;

	[Tooltip("Jump velocity")]
	[Header("Jump and gravity specifics")]
	public float jumpVelocity;

	[Tooltip("Multiplier applied to gravity when the player is falling")]
	public float fallMultiplier;

	[Tooltip("Multiplier applied to gravity when the player is holding jump")]
	public float holdJumpMultiplier;

	[Range(0f, 1f)]
	[Tooltip("Player friction against floor")]
	public float frictionAgainstFloor;

	[Space(10f)]
	[Tooltip("Player can long jump")]
	public bool canLongJump;

	[Header("Slope and step specifics")]
	[Tooltip("Distance from the player feet used to check if the player is touching the ground")]
	public float groundCheckerThrashold;

	[Tooltip("Distance from the player center used to check if the player is touching a step")]
	public float stepCheckerThrashold;

	[Space(10f)]
	[Tooltip("Multipler factor for gravity")]
	public float gravityMultiplier;

	[Tooltip("Multipler factor for gravity used on change of normal")]
	public float gravityMultiplyerOnSlideChange;

	[Tooltip("Distance from the player head used to check if the player is touching a wall")]
	[Header("Wall slide specifics")]
	public float wallCheckerThrashold;

	[Tooltip("Wall checker distance from the player center")]
	public float hightWallCheckerChecker;

	[Tooltip("Multiplier used when the player is jumping from a wall")]
	[Space(10f)]
	public float jumpFromWallMultiplier;

	[Tooltip("Factor used to determine the height of the jump")]
	public float multiplierVerticalLeap;

	[Tooltip("FP camera head height")]
	public Vector3 POV_normalHeadHeight;

	[Header("References")]
	public StateCamera cameraState;

	[Tooltip("Character camera")]
	public GameObject characterCamera;

	[Tooltip("Character model")]
	public GameObject characterModel;

	[Tooltip("Character rotation speed when the forward direction is changed")]
	public float characterModelRotationSmooth;

	[Tooltip("Default character mesh")]
	[Space(10f)]
	public GameObject meshCharacter;

	[Tooltip("Head reference")]
	public Transform headPoint;

	[Tooltip("Input reference")]
	[Space(10f)]
	public InputReader input;

	[Space(10f)]
	public bool debug;

	[Header("Events")]
	[SerializeField]
	private UnityEvent OnJump;

	[Space(15f)]
	public float minimumVerticalSpeedToLandEvent;

	[SerializeField]
	private UnityEvent OnLand;

	[Space(15f)]
	public float minimumHorizontalSpeedToFastEvent;

	[SerializeField]
	private UnityEvent OnFast;

	[Space(15f)]
	[SerializeField]
	private UnityEvent OnAttack;

	[Space(15f)]
	private Vector3 forward;

	private Vector3 globalForward;

	private Vector3 reactionForward;

	private Vector3 down;

	private Vector3 globalDown;

	private Vector3 reactionGlobalDown;

	private float currentSurfaceAngle;

	private Vector3 wallNormal;

	private Vector3 groundNormal;

	private Vector3 prevGroundNormal;

	private bool prevGrounded;

	private float coyoteJumpMultiplier;

	private bool isGrounded;

	private bool isTouchingStep;

	private bool isJumping;

	private bool isAttack;

	private Vector2 axisInput;

	private Vector2 cameraInput;

	private bool jump;

	private bool jumpHold;

	[HideInInspector]
	public float targetAngle;

	private Rigidbody rigidbody;

	private CapsuleCollider collider;

	private float originalColliderHeight;

	private Vector3 currVelocity;

	private float turnSmoothVelocity;

	private bool lockRotation;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void CheckGrounded()
	{
	}

	private void CheckStep()
	{
	}

	private void CheckDirections()
	{
	}

	private void MoveWalk()
	{
	}

	private void MoveRotation()
	{
	}

	private void MoveJump()
	{
	}

	private void ApplyGravity()
	{
	}

	private void UpdateEvents()
	{
	}

	private void SetFriction(float _frictionWall, bool _isMinimum)
	{
	}

	private float RoundValue(float _value)
	{
		return 0f;
	}

	public bool GetGrounded()
	{
		return false;
	}

	public bool GetTouchingStep()
	{
		return false;
	}

	public float GetOriginalColliderHeight()
	{
		return 0f;
	}

	public void SetLockRotation(bool _lock)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
