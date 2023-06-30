using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	[HelpURL("https://documentation.therabytes.de/better-ui/AboutMaterials.html")]
	public class Materials : SingletonScriptableObject<Materials>
	{
		[Serializable]
		public class MaterialInfo
		{
			public string Name;

			public Material Material;

			public VertexMaterialData Properties;

			public MaterialEffect Effect;

			public override string ToString()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CSetTogglePropertyDelayed_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Material material;

			public string toggleName;

			public bool toggle;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSetTogglePropertyDelayed_003Ed__11(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private const string STANDARD = "Standard";

		private const string GRAYSCALE = "Grayscale";

		private const string HUE_SATURATION_BRIGHTNESS = "Hue Saturation Brightness";

		private static readonly List<string> materialOrder;

		[SerializeField]
		private List<MaterialInfo> materials;

		private static string FilePath => null;

		private void OnEnable()
		{
		}

		private void EnsurePredefinedMaterials()
		{
		}

		private void AddIfNotPresent(string name, Func<MaterialEffect, MaterialInfo> CreateMaterial, params MaterialEffect[] preservedLayerEffects)
		{
		}

		[IteratorStateMachine(typeof(_003CSetTogglePropertyDelayed_003Ed__11))]
		private IEnumerator SetTogglePropertyDelayed(Material material, string toggleName, bool toggle)
		{
			return null;
		}

		public MaterialInfo GetMaterialInfo(string name, MaterialEffect e)
		{
			return null;
		}

		public Material GetMaterial(string name)
		{
			return null;
		}

		public List<string> GetAllMaterialNames()
		{
			return null;
		}

		public HashSet<MaterialEffect> GetAllMaterialEffects(string name)
		{
			return null;
		}

		public Materials()
		{
			((SingletonScriptableObject<>)(object)this)._002Ector();
		}
	}
}
