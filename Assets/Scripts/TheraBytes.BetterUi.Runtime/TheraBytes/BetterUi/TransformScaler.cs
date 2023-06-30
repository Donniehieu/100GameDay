using UnityEngine;
using UnityEngine.Serialization;

namespace TheraBytes.BetterUi
{
	[HelpURL("https://documentation.therabytes.de/better-ui/TransformScaler.html")]
	[AddComponentMenu("Better UI/Helpers/Transform Scaler", 30)]
	[ExecuteAlways]
	public class TransformScaler : ResolutionSizer<Vector3>
	{
		[SerializeField]
		[FormerlySerializedAs("scaleSizer")]
		private Vector3SizeModifier scaleSizerFallback;

		[SerializeField]
		private Vector3SizeConfigCollection customScaleSizers;

		private DrivenRectTransformTracker rectTransformTracker;

		public Vector3SizeModifier ScaleSizer => null;

		protected override ScreenDependentSize<Vector3> sizer => null;

		protected override void OnDisable()
		{
		}

		protected override void ApplySize(Vector3 newSize)
		{
		}

		public TransformScaler()
		{
			((ResolutionSizer<>)(object)this)._002Ector();
		}
	}
}
