using System.Diagnostics;

namespace UnityEngine.Rendering.Universal
{
	[Conditional("UNITY_EDITOR")]
	internal class URPHelpURLAttribute : CoreRPHelpURLAttribute
	{
		public URPHelpURLAttribute(string pageName)
			: base(null, null)
		{
		}
	}
}
