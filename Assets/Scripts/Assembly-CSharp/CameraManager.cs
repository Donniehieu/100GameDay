using BigBear.Core.Runtime.Singleton;
using Cinemachine;
using Dossamer.PanZoom;
using UnityEngine;

public class CameraManager : Singleton<CameraManager>
{
	[Header("Camera properties")]
	public PanZoomBehavior panZoom;

	public GameObject thirdPersonCamera;

	public GameObject firstPersonCamera;

	public Camera mainCamera;

	public CharacterManager characterManager;

	[Space(10f)]
	public LayerMask thirdPersonMask;

	public LayerMask firstPersonMask;

	[Space(10f)]
	public bool activeDebug;

	public StateCamera State;

	private bool isUpdatePlayerRotation;

	private CinemachineVirtualCamera curVCam;

	public void ChangeModeCamera()
	{
	}

	public void SetCamera(StateCamera state)
	{
	}

	public void SetDebug()
	{
	}

	public override void Init()
	{
	}

	private void Update()
	{
	}

	public void OnCameraLive(ICinemachineCamera nextCam, ICinemachineCamera previousCam)
	{
	}

	public CameraManager()
	{
		((Singleton<T>)(object)this)._002Ector();
	}
}
