using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine
{
	internal class BlendSourceVirtualCamera : ICinemachineCamera
	{
		public CinemachineBlend Blend
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Name => null;

		public string Description => null;

		public int Priority
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Transform LookAt
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Transform Follow
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CameraState State
		{
			[CompilerGenerated]
			get
			{
				return default(CameraState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public GameObject VirtualCameraGameObject => null;

		public bool IsValid => false;

		public ICinemachineCamera ParentCamera => null;

		public BlendSourceVirtualCamera(CinemachineBlend blend)
		{
		}

		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return false;
		}

		public CameraState CalculateNewState(float deltaTime)
		{
			return default(CameraState);
		}

		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		public void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		public void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}
	}
}
