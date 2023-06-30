using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace MeshCombineStudio
{
	[Serializable]
	public struct CombineCondition
	{
		public static HashSet<object> countSet;

		public int matInstanceId;

		public int lightmapIndex;

		public ShadowCastingMode shadowCastingMode;

		public bool receiveShadows;

		public float lightmapScale;

		public LightProbeUsage lightProbeUsage;

		public ReflectionProbeUsage reflectionProbeUsage;

		public Transform probeAnchor;

		public MotionVectorGenerationMode motionVectorGenerationMode;

		public int layer;

		public int rootInstanceId;

		public static CombineCondition Default => default(CombineCondition);

		public static void MakeFoundReport(FoundCombineConditions fcc)
		{
		}

		public void ReadFromGameObject(int rootInstanceId, CombineConditionSettings combineConditions, bool copyBakedLighting, GameObject go, Transform t, MeshRenderer mr, Material mat)
		{
		}

		private float GetLightmapScale(MeshRenderer mr)
		{
			return 0f;
		}

		private void SetLightmapScale(MeshRenderer mr, float lightmapScale)
		{
		}

		public void WriteToGameObject(GameObject go, MeshRenderer mr)
		{
		}
	}
}
