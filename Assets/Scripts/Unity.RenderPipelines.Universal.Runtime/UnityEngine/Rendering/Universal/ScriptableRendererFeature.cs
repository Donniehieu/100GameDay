using System;

namespace UnityEngine.Rendering.Universal
{
	[ExcludeFromPreset]
	public abstract class ScriptableRendererFeature : ScriptableObject, IDisposable
	{
		[HideInInspector]
		[SerializeField]
		private bool m_Active;

		public bool isActive => false;

		public abstract void Create();

		public virtual void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData)
		{
		}

		public abstract void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData);

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		internal virtual bool SupportsNativeRenderPass()
		{
			return false;
		}

		public void SetActive(bool active)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
