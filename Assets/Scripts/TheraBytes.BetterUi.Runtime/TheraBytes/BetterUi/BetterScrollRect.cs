using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	[HelpURL("https://documentation.therabytes.de/better-ui/BetterScrollRect.html")]
	[AddComponentMenu("Better UI/Controls/Better Scroll Rect", 30)]
	public class BetterScrollRect : ScrollRect, IResolutionDependency
	{
		[Range(0f, 1f)]
		[SerializeField]
		private float horizontalStartPosition;

		[Range(0f, 1f)]
		[SerializeField]
		private float verticalStartPosition;

		[SerializeField]
		private FloatSizeModifier horizontalSpacingFallback;

		[SerializeField]
		private FloatSizeConfigCollection customHorizontalSpacingSizers;

		[SerializeField]
		private FloatSizeModifier verticalSpacingFallback;

		[SerializeField]
		private FloatSizeConfigCollection customVerticalSpacingSizers;

		public Vector2 DragStartPosition
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Bounds ContentBounds
		{
			get
			{
				return default(Bounds);
			}
			set
			{
			}
		}

		public float HorizontalStartPosition
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float VerticalStartPosition
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public FloatSizeModifier HorizontalSpacingSizer => null;

		public FloatSizeModifier VerticalSpacingSizer => null;

		protected override void OnEnable()
		{
		}

		public void OnResolutionChanged()
		{
		}

		protected override void Start()
		{
		}

		public void ResetToStartPosition()
		{
		}

		private void CalculateSize()
		{
		}
	}
}
