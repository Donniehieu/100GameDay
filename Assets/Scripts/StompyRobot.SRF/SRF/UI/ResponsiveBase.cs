using UnityEngine;

namespace SRF.UI
{
	[RequireComponent(typeof(RectTransform))]
	[ExecuteInEditMode]
	public abstract class ResponsiveBase : SRMonoBehaviour
	{
		private bool _queueRefresh;

		protected RectTransform RectTransform => null;

		protected void OnEnable()
		{
		}

		protected void OnRectTransformDimensionsChange()
		{
		}

		protected void Update()
		{
		}

		protected abstract void Refresh();

		[ContextMenu("Refresh")]
		private void DoRefresh()
		{
		}
	}
}
