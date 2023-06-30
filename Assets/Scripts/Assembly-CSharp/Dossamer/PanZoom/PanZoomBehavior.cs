using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dossamer.PanZoom
{
	[Serializable]
	public class PanZoomBehavior : MonoBehaviour
	{
		[Serializable]
		public class InputMethodFloatDictionary : SerializableDictionary<InputMethod, float>
		{
			public InputMethodFloatDictionary()
			{
				((SerializableDictionary<, >)(object)this)._002Ector();
			}
		}

		[Serializable]
		public class AxisAxisDataDictionary : SerializableDictionary<Axis, AxisData>
		{
			public AxisAxisDataDictionary()
			{
				((SerializableDictionary<, >)(object)this)._002Ector();
			}
		}

		[SerializeField]
		public InputMethodFloatDictionary inputMultipliers;

		[SerializeField]
		protected MouseButton mouseButton;

		[SerializeField]
		private float minViewPortSize;

		[SerializeField]
		private float maxViewPortSize;

		private Vector3 startPosition;

		protected Vector3 mousePanStartPosition;

		protected Vector3? lastMouseDelta;

		protected float? lastPinchMagnitude;

		[SerializeField]
		protected Camera referenceCamera;

		[SerializeField]
		protected float precision;

		private bool IsActive;

		[SerializeField]
		public AxisAxisDataDictionary axes;

		[SerializeField]
		protected GameObject focusTarget;

		[SerializeField]
		private float minForwardDistanceFromFocusTarget;

		[SerializeField]
		private float minFieldOfView;

		[SerializeField]
		private float maxFieldOfView;

		[SerializeField]
		private GameObject triggerBoundaryObject;

		[SerializeField]
		private string triggerBoundaryLayerName;

		private Vector3 lastTransformPosition;

		[SerializeField]
		protected bool isContributionProportionalToDistFromTarget;

		protected Dictionary<InputMethod, bool> isInputMethodActive;

		private float debugOffset;

		public bool IsPanning
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public event EventHandler PanStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler PanEnded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public Camera GetReferenceCamera()
		{
			return null;
		}

		public void StartCamBuilding()
		{
		}

		public void SetActive(bool isactive)
		{
		}

		protected void OnPanStarted(EventArgs e)
		{
		}

		protected void OnPanEnded(EventArgs e)
		{
		}

		public float GetMinForwardDistFromTarget()
		{
			return 0f;
		}

		public GameObject GetFocusTarget()
		{
			return null;
		}

		public void ReassignTarget(GameObject target)
		{
		}

		protected virtual void Awake()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private bool IsCameraInBoundary()
		{
			return false;
		}

		private bool IsPositionInBoundary(Vector3 position)
		{
			return false;
		}

		private RaycastHit[] BoundaryCast(Vector3 start, Vector3 end)
		{
			return null;
		}

		private void UndoCameraOrthogonalAxisTranslation()
		{
		}

		private void ClampPositionToTriggerBoundary()
		{
		}

		private void DebugDrawPoint(Vector3 position, Color color)
		{
		}

		private void ClampPositionToTriggerBoundary(Vector3 lastFinalPosition)
		{
		}

		public void DrawDebugRays()
		{
		}

		public float GetClampedCameraSize(float size)
		{
			return 0f;
		}

		public float GetClampedCameraFOV(float size)
		{
			return 0f;
		}

		public void UpdateAxes()
		{
		}

		protected virtual void CheckIsPanning()
		{
		}

		private List<AxisData> GetAxesOfType(InputMethod method)
		{
			return null;
		}

		public bool GetIsAxisEnabled(Axis axis)
		{
			return false;
		}

		public void SetIsAxisEnabled(Axis axis, bool isEnabled)
		{
		}

		private void ClampPerspectiveClose()
		{
		}

		protected void AddAxisToContribution(AxisData axis, ref Vector3 contribution, float magnitude)
		{
		}

		private void AddMagnitudeToCamSize(float magnitude)
		{
		}

		protected virtual void UpdatePosition()
		{
		}

		public float GetForwardDotToFocusTarget()
		{
			return 0f;
		}

		public float GetForwardDotToFocusTarget(Vector3 position)
		{
			return 0f;
		}

		private Vector3 GetCrossVector()
		{
			return default(Vector3);
		}

		protected float GetPinchZoomImmediateMagnitude()
		{
			return 0f;
		}
	}
}
