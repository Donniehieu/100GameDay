using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TheraBytes.BetterUi
{
	[AddComponentMenu("Better UI/Helpers/Game Object Activator", 30)]
	[HelpURL("https://documentation.therabytes.de/better-ui/GameObjectActivator.html")]
	[ExecuteAlways]
	public class GameObjectActivator : UIBehaviour, IResolutionDependency
	{
		[Serializable]
		public class Settings : IScreenConfigConnection
		{
			public List<GameObject> ActiveObjects;

			public List<GameObject> InactiveObjects;

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

		public void Apply()
		{
		}
	}
}
