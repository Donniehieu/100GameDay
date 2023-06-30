using UnityEngine;
using UnityEngine.UI;

namespace BigBear.Core.Runtime.Tutorial
{
	public class GuideMask : MaskableGraphic, ICanvasRaycastFilter
	{
		public static GuideMask Self;

		private RectTransform _target;

		private Vector2 _targetMin;

		private Vector2 _targetMax;

		[SerializeField]
		private RectTransform _targetArea;

		private Camera camera;

		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return false;
		}

		public void Close()
		{
		}

		public void Play(RectTransform target)
		{
		}

		public void Init()
		{
		}

		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		private void LateUpdate()
		{
		}

		private void RefreshView()
		{
		}
	}
}
