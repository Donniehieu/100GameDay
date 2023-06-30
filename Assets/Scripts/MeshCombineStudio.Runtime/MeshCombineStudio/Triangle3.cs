using UnityEngine;

namespace MeshCombineStudio
{
	public struct Triangle3
	{
		public Vector3 a;

		public Vector3 b;

		public Vector3 c;

		public Vector3 dirAb;

		public Vector3 dirAc;

		public Vector3 dirBc;

		public Vector3 h1;

		public float ab;

		public float ac;

		public float bc;

		public float area;

		public float h;

		public float ah;

		public float hb;

		public void Calc()
		{
		}
	}
}
