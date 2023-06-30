using System;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	[ExecuteAlways]
	[HelpURL("https://documentation.therabytes.de/better-ui/BetterAspectRatioFitter.html")]
	[AddComponentMenu("Better UI/Layout/Better Aspect Ratio Fitter", 30)]
	public class BetterAspectRatioFitter : AspectRatioFitter, IResolutionDependency
	{
		[Serializable]
		public class Settings : IScreenConfigConnection
		{
			public AspectMode AspectMode;

			public float AspectRatio;

			[SerializeField]
			private string screenConfigName;

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
		public class SettingsConfigCollection : SizeConfigCollection<Settings>
		{
			public SettingsConfigCollection()
			{
				((SizeConfigCollection<>)(object)this)._002Ector();
			}
		}

		[SerializeField]
		private Settings settingsFallback;

		[SerializeField]
		private SettingsConfigCollection customSettings;

		public Settings CurrentSettings => null;

		protected override void OnEnable()
		{
		}

		public void OnResolutionChanged()
		{
		}

		private void Apply()
		{
		}
	}
}
