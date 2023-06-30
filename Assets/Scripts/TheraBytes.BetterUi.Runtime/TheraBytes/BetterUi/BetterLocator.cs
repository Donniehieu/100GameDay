using System;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("Better UI/Layout/Better Locator", 30)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[HelpURL("https://documentation.therabytes.de/better-ui/BetterLocator.html")]
	public class BetterLocator : MonoBehaviour, IResolutionDependency
	{
		[Serializable]
		public class RectTransformDataConfigCollection : SizeConfigCollection<RectTransformData>
		{
			public RectTransformDataConfigCollection()
			{
				((SizeConfigCollection<>)(object)this)._002Ector();
			}
		}

		[SerializeField]
		private RectTransformData transformFallback;

		[SerializeField]
		private RectTransformDataConfigCollection transformConfigs;

		public RectTransformData CurrentTransformData => null;

		private RectTransform rectTransform => null;

		private void OnEnable()
		{
		}

		public void OnResolutionChanged()
		{
		}

		private void InitTransformFallback()
		{
		}
	}
}
