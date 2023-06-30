using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	[DebuggerDisplay("RendererList ({handle})")]
	public struct RendererListHandle
	{
		private bool m_IsValid;

		internal int handle
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal RendererListHandle(int handle)
		{
		}

		public static implicit operator int(RendererListHandle handle)
		{
			return 0;
		}

		public static implicit operator UnityEngine.Rendering.RendererUtils.RendererList(RendererListHandle rendererList)
		{
			return default(UnityEngine.Rendering.RendererUtils.RendererList);
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
