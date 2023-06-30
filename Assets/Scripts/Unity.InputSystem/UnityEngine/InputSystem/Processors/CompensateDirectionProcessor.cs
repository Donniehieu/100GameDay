using System.ComponentModel;
using UnityEngine.Scripting;

namespace UnityEngine.InputSystem.Processors
{
	[DesignTimeVisible(false)]
	[Preserve]
	internal class CompensateDirectionProcessor : InputProcessor<Vector3>
	{
		public override Vector3 Process(Vector3 value, InputControl control)
		{
			return default(Vector3);
		}

		public override string ToString()
		{
			return null;
		}

		public CompensateDirectionProcessor()
		{
			((InputProcessor<>)(object)this)._002Ector();
		}
	}
}
