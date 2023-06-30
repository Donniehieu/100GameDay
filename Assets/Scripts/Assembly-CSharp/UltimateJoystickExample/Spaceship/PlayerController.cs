using UnityEngine;

namespace UltimateJoystickExample.Spaceship
{
	public class PlayerController : MonoBehaviour
	{
		[Header("Speeds")]
		public float rotationSpeed;

		public float accelerationSpeed;

		public float maxSpeed;

		public float shootingCooldown;

		[Header("Assigned Variables")]
		public GameObject bulletPrefab;

		private Rigidbody myRigidbody;

		public Transform gunTrans;

		public Transform bulletSpawnPos;

		public GameObject playerVisuals;

		private float shootingTimer;

		private bool canControl;

		private Vector3 movePosition;

		private Vector3 shootPosition;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void CheckExitScreen()
		{
		}

		private void CreateBullets()
		{
		}
	}
}
