using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TheraBytes.BetterUi
{
	[AddComponentMenu("Better UI/Layout/Anchor Override", 30)]
	[HelpURL("https://documentation.therabytes.de/better-ui/AnchorOverride.html")]
	[ExecuteAlways]
	public class AnchorOverride : UIBehaviour, IResolutionDependency
	{
		[Serializable]
		public class AnchorReference
		{
			public enum ReferenceLocation
			{
				Disabled = 0,
				Center = 1,
				Pivot = 2,
				LowerLeft = 3,
				UpperRight = 4
			}

			[SerializeField]
			private RectTransform reference;

			[SerializeField]
			private ReferenceLocation minX;

			[SerializeField]
			private ReferenceLocation maxX;

			[SerializeField]
			private ReferenceLocation minY;

			[SerializeField]
			private ReferenceLocation maxY;

			public RectTransform Reference
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public ReferenceLocation MinX => default(ReferenceLocation);

			public ReferenceLocation MaxX => default(ReferenceLocation);

			public ReferenceLocation MinY => default(ReferenceLocation);

			public ReferenceLocation MaxY => default(ReferenceLocation);
		}

		[Serializable]
		public class AnchorReferenceCollection : IScreenConfigConnection
		{
			[SerializeField]
			private List<AnchorReference> elements;

			[SerializeField]
			private string screenConfigName;

			public List<AnchorReference> Elements => null;

			public string ScreenConfigName
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		[Serializable]
		public class AnchorReferenceCollectionConfigCollection : SizeConfigCollection<AnchorReferenceCollection>
		{
			public AnchorReferenceCollectionConfigCollection()
			{
				((SizeConfigCollection<>)(object)this)._002Ector();
			}
		}

		[SerializeField]
		private AnchorReferenceCollection anchorsFallback;

		[SerializeField]
		private AnchorReferenceCollectionConfigCollection anchorsConfigs;

		[SerializeField]
		private bool isAnimated;

		[SerializeField]
		private float acceleration;

		[SerializeField]
		private float maxMoveSpeed;

		[SerializeField]
		private float snapThreshold;

		private AnchorReferenceCollection currentAnchors;

		private Canvas canvas;

		private DrivenRectTransformTracker rectTransformTracker;

		private float currentVelocity;

		public AnchorReferenceCollection CurrentAnchors => null;

		private RectTransform RectTransform => null;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void OnResolutionChanged()
		{
		}

		private void Update()
		{
		}

		public void UpdateAnchors(bool forceInstant)
		{
		}

		private static Vector2 GetAnchorPosition(AnchorReference a, Rect rect, AnchorReference.ReferenceLocation location)
		{
			return default(Vector2);
		}

		private bool TryGetAnchor(AnchorReference anchorRef, out Rect anchorObject)
		{
			anchorObject = default(Rect);
			return false;
		}

		private bool IsParentOf(Transform transform)
		{
			return false;
		}
	}
}
