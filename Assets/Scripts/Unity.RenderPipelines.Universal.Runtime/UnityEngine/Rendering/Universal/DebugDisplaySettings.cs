using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal
{
	public class DebugDisplaySettings : IDebugDisplaySettingsQuery
	{
		private readonly HashSet<IDebugDisplaySettingsData> m_Settings;

		private static readonly Lazy<DebugDisplaySettings> s_Instance;

		public static DebugDisplaySettings Instance => null;

		private DebugDisplaySettingsCommon CommonSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal DebugDisplaySettingsMaterial MaterialSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal DebugDisplaySettingsRendering RenderingSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal DebugDisplaySettingsLighting LightingSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool AreAnySettingsActive => false;

		public bool IsLightingActive => false;

		public bool IsPostProcessingAllowed => false;

		public bool TryGetScreenClearColor(ref Color color)
		{
			return false;
		}

		private TData Add<TData>(TData newData) where TData : IDebugDisplaySettingsData
		{
			return default(TData);
		}

		private DebugDisplaySettings()
		{
		}

		internal void Reset()
		{
		}

		internal void ForEach(Action<IDebugDisplaySettingsData> onExecute)
		{
		}
	}
}
