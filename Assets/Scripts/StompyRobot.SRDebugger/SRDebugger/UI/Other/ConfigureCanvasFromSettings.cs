using System.ComponentModel;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	[RequireComponent(typeof(Canvas))]
	public class ConfigureCanvasFromSettings : SRMonoBehaviour
	{
		private Canvas _canvas;

		private CanvasScaler _canvasScaler;

		private float _originalScale;

		private float _lastSetScale;

		private Settings _settings;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void SettingsOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
		}
	}
}
