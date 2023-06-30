using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	[Obsolete("Use the updated RendererList API which is defined in the UnityEngine.Rendering.RendererUtils namespace.")]
	public struct RendererListDesc
	{
		public SortingCriteria sortingCriteria;

		public PerObjectData rendererConfiguration;

		public RenderQueueRange renderQueueRange;

		public RenderStateBlock? stateBlock;

		public Material overrideMaterial;

		public bool excludeObjectMotionVectors;

		public int layerMask;

		public int overrideMaterialPassIndex;

		internal CullingResults cullingResult
		{
			[CompilerGenerated]
			readonly get
			{
				return default(CullingResults);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal Camera camera
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal ShaderTagId passName
		{
			[CompilerGenerated]
			readonly get
			{
				return default(ShaderTagId);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal ShaderTagId[] passNames
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public RendererListDesc(ShaderTagId passName, CullingResults cullingResult, Camera camera)
		{
		}

		public RendererListDesc(ShaderTagId[] passNames, CullingResults cullingResult, Camera camera)
		{
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
