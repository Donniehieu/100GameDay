using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal
{
	internal class DebugDisplaySettingsLighting : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		private static class Strings
		{
			public static readonly DebugUI.Widget.NameAndTooltip LightingDebugMode;

			public static readonly DebugUI.Widget.NameAndTooltip LightingFeatures;
		}

		internal static class WidgetFactory
		{
			internal static DebugUI.Widget CreateLightingDebugMode(DebugDisplaySettingsLighting data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateLightingFeatures(DebugDisplaySettingsLighting data)
			{
				return null;
			}
		}

		private class SettingsPanel : DebugDisplaySettingsPanel
		{
			public override string PanelName => null;

			public SettingsPanel(DebugDisplaySettingsLighting data)
			{
			}
		}

		internal DebugLightingMode DebugLightingMode
		{
			[CompilerGenerated]
			get
			{
				return default(DebugLightingMode);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal DebugLightingFeatureFlags DebugLightingFeatureFlagsMask
		{
			[CompilerGenerated]
			get
			{
				return default(DebugLightingFeatureFlags);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool AreAnySettingsActive => false;

		public bool IsPostProcessingAllowed => false;

		public bool IsLightingActive => false;

		public bool TryGetScreenClearColor(ref Color color)
		{
			return false;
		}

		public IDebugDisplaySettingsPanelDisposable CreatePanel()
		{
			return null;
		}
	}
}
