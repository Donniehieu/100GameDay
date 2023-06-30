using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lean.Touch
{
	[AddComponentMenu("Lean/Touch/Lean Drag Trail")]
	[ExecuteInEditMode]
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanDragTrail")]
	public class LeanDragTrail : MonoBehaviour
	{
		[Serializable]
		public class FingerData : LeanFingerData
		{
			public LineRenderer Line;

			public float Age;

			public float Width;
		}

		public LeanFingerFilter Use;

		public LeanScreenDepth ScreenDepth;

		public LineRenderer Prefab;

		public int MaxTrails;

		public float FadeTime;

		public Color StartColor;

		public Color EndColor;

		[HideInInspector]
		[SerializeField]
		protected List<FingerData> fingerDatas;

		public void AddFinger(LeanFinger finger)
		{
		}

		public void RemoveFinger(LeanFinger finger)
		{
		}

		public void RemoveAllFingers()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void UpdateLine(FingerData fingerData, LeanFinger finger, LineRenderer line)
		{
		}

		protected virtual void HandleFingerUp(LeanFinger finger)
		{
		}
	}
}
