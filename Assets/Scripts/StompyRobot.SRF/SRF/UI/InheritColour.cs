using UnityEngine;
using UnityEngine.UI;

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/Inherit Colour")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Graphic))]
	public class InheritColour : SRMonoBehaviour
	{
		private Graphic _graphic;

		public Graphic From;

		private Graphic Graphic => null;

		private void Refresh()
		{
		}

		private void Update()
		{
		}

		private void Start()
		{
		}
	}
}
