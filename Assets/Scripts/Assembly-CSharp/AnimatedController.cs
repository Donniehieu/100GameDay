using UnityEngine;

public class AnimatedController : MonoBehaviour
{
	[Header("References")]
	public CharacterManager characterManager;

	public Rigidbody rigidbodyCharacter;

	[Header("Animation specifics")]
	public float velocityAnimationMultiplier;

	private Animator anim;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void OnAttack()
	{
	}

	public void OnJump()
	{
	}

	private bool CheckAnimationGrounded()
	{
		return false;
	}
}
