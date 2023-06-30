using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace TheraBytes.BetterUi
{
	[HelpURL("https://documentation.therabytes.de/better-ui/LocationAnimations.html")]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("Better UI/Animation/Location Animations", 30)]
	public class LocationAnimations : MonoBehaviour
	{
		[Serializable]
		public class LocationAnimationEvent : UnityEvent
		{
			public LocationAnimationEvent()
			{
			}

			public LocationAnimationEvent(params UnityAction[] actions)
			{
			}
		}

		[Serializable]
		public class LocationAnimationUpdateEvent : UnityEvent<float>
		{
			public LocationAnimationUpdateEvent()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}

			public LocationAnimationUpdateEvent(params UnityAction<float>[] actions)
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		[Serializable]
		public class RectTransformDataConfigCollection : SizeConfigCollection<RectTransformData>
		{
			public RectTransformDataConfigCollection()
			{
				((SizeConfigCollection<>)(object)this)._002Ector();
			}
		}

		[Serializable]
		public class LocationData
		{
			[SerializeField]
			private string name;

			[SerializeField]
			private RectTransformData transformFallback;

			[SerializeField]
			private RectTransformDataConfigCollection transformConfigs;

			public string Name
			{
				get
				{
					return null;
				}
				internal set
				{
				}
			}

			public RectTransformData CurrentTransformData => null;
		}

		[Serializable]
		public class Animation
		{
			[SerializeField]
			private string name;

			[SerializeField]
			private string from;

			[SerializeField]
			private string to;

			[SerializeField]
			private AnimationCurve curve;

			[SerializeField]
			private LocationAnimationEvent actionBeforeStart;

			[SerializeField]
			private LocationAnimationEvent actionAfterFinish;

			[SerializeField]
			private LocationAnimationUpdateEvent actionOnUpdating;

			[SerializeField]
			private bool animateWithEulerRotation;

			[SerializeField]
			private float timeScale;

			public string Name
			{
				get
				{
					return null;
				}
				internal set
				{
				}
			}

			public string From
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public string To
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public AnimationCurve Curve
			{
				get
				{
					return null;
				}
				internal set
				{
				}
			}

			public bool AnimateWithEulerRotation
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public float TimeScale
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public LocationAnimationEvent ActionBeforeStart => null;

			public LocationAnimationEvent ActionAfterFinish => null;

			public LocationAnimationUpdateEvent ActionOnUpdating => null;
		}

		[Serializable]
		public class AnimationState
		{
			public Animation Animation
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public RectTransformData From
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public RectTransformData To
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public float Time
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float Duration
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool Loop
			{
				[CompilerGenerated]
				get
				{
					return false;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}

			public float TimeScale
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public LocationAnimationEvent ActionAfterFinish
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				internal set
				{
				}
			}
		}

		[SerializeField]
		private bool useRelativeLocations;

		[SerializeField]
		private List<LocationData> locations;

		[SerializeField]
		private List<Animation> animations;

		[SerializeField]
		private string startLocation;

		[SerializeField]
		private string startUpAnimation;

		[SerializeField]
		private LocationAnimationEvent actionOnInit;

		private RectTransformData referenceLocation;

		private AnimationState runningAnimation;

		public RectTransform RectTransform => null;

		public List<LocationData> Locations => null;

		public List<Animation> Animations => null;

		public string StartUpAnimation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string StartLocation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsAnimating => false;

		public bool UseRelativeLocations => false;

		public AnimationState RunningAnimation => null;

		public RectTransformData ReferenceLocation => null;

		private void Start()
		{
		}

		public void StopCurrentAnimation()
		{
		}

		public void StartAnimation(string name)
		{
		}

		public void StartAnimation(string name, float timeScale)
		{
		}

		public void StartAnimation(string name, LocationAnimationEvent onFinish)
		{
		}

		public void StartAnimation(string name, float timeScale, LocationAnimationEvent onFinish)
		{
		}

		public void StartAnimation(Animation ani, float? timeScale, LocationAnimationEvent onFinish)
		{
		}

		private void Update()
		{
		}

		public void UpdateCurrentAnimation(float deltaTime)
		{
		}

		public void SetToLocation(string name)
		{
		}

		public LocationData GetLocation(string name)
		{
			return null;
		}

		public void ResetReferenceLocation()
		{
		}

		public void ResetReferenceLocation(RectTransform rectTransform)
		{
		}

		public void ResetReferenceLocation(RectTransformData reference)
		{
		}

		private void PushTransformData(LocationData loc)
		{
		}

		private void EnsureReferenceLocation(bool force = false)
		{
		}

		private RectTransformData GetLocationTransformFallbackCurrent(string name)
		{
			return null;
		}

		public Animation GetAnimation(string name)
		{
			return null;
		}
	}
}
