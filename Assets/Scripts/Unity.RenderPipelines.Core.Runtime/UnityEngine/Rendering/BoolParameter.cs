using System;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
	[Serializable]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class BoolParameter : VolumeParameter<bool>
	{
		public BoolParameter(bool value, bool overrideState = false)
		{
			((VolumeParameter<>)(object)this)._002Ector();
		}
	}
}
