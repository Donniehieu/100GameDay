using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Lean.Touch
{
	[HelpURL("https://carloswilkes.github.io/Documentation/LeanTouch#LeanPulseScale")]
	[AddComponentMenu("Lean/Touch/Lean Pulse Scale")]
	public class LeanPulseScale : MonoBehaviour
	{
		[Tooltip("The transform.localScale before pulsing.")]
		public Vector3 BaseScale;

		[Tooltip("The current scale multiplier.")]
		public float Size;

		[Tooltip("The interval between each pulse in seconds.")]
		public float PulseInterval;

		[Tooltip("The amount Size will be incremented each pulse.")]
		public float PulseSize;

		[Tooltip("If you want this component to change smoothly over time, then this allows you to control how quick the changes reach their target value.\n\n-1 = Instantly change.\n\n1 = Slowly change.\n\n10 = Quickly change.")]
		[FormerlySerializedAs("Dampening")]
		public float Damping;

		[NonSerialized]
		private float counter;

		protected virtual void Update()
		{
		}
	}
}
