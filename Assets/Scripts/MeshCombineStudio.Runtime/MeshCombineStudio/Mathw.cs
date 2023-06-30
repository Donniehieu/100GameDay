using UnityEngine;

namespace MeshCombineStudio
{
	public static class Mathw
	{
		public static readonly int[] bits;

		public static Vector3 Clamp(Vector3 v, float min, float max)
		{
			return default(Vector3);
		}

		public static Vector3 FloatToVector3(float v)
		{
			return default(Vector3);
		}

		public static float SinDeg(float angle)
		{
			return 0f;
		}

		public static float GetMax(Vector3 v)
		{
			return 0f;
		}

		public static Vector3 SetMin(Vector3 v, float min)
		{
			return default(Vector3);
		}

		public static Vector3 Snap(Vector3 v, float snapSize)
		{
			return default(Vector3);
		}

		public static Vector3 SnapRound(Vector3 v, float snapSize)
		{
			return default(Vector3);
		}

		public static Vector3 Divide(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public static Vector3 Divide(float a, Vector3 b)
		{
			return default(Vector3);
		}

		public static Vector3 Scale(Vector3 a, Int3 b)
		{
			return default(Vector3);
		}

		public static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		public static bool IntersectAABB3Sphere3(AABB3 box, Sphere3 sphere)
		{
			return false;
		}

		public static bool IntersectAABB3Triangle3(Vector3 boxCenter, Vector3 boxHalfSize, Triangle3 triangle)
		{
			return false;
		}

		private static void GetMinMax(float x0, float x1, float x2, out float min, out float max)
		{
			min = default(float);
			max = default(float);
		}

		private static bool PlaneBoxOverlap(Vector3 normal, Vector3 vert, Vector3 maxBox)
		{
			return false;
		}

		private static float Abs(float v)
		{
			return 0f;
		}

		private static bool AxisTest_X01(Vector3 v0, Vector3 v2, Vector3 boxHalfSize, float a, float b, float fa, float fb, out float min, out float max)
		{
			min = default(float);
			max = default(float);
			return false;
		}

		private static bool AxisTest_X2(Vector3 v0, Vector3 v1, Vector3 boxHalfSize, float a, float b, float fa, float fb, out float min, out float max)
		{
			min = default(float);
			max = default(float);
			return false;
		}

		private static bool AxisTest_Y02(Vector3 v0, Vector3 v2, Vector3 boxHalfSize, float a, float b, float fa, float fb, out float min, out float max)
		{
			min = default(float);
			max = default(float);
			return false;
		}

		private static bool AxisTest_Y1(Vector3 v0, Vector3 v1, Vector3 boxHalfSize, float a, float b, float fa, float fb, out float min, out float max)
		{
			min = default(float);
			max = default(float);
			return false;
		}

		private static bool AxisTest_Z12(Vector3 v1, Vector3 v2, Vector3 boxHalfSize, float a, float b, float fa, float fb, out float min, out float max)
		{
			min = default(float);
			max = default(float);
			return false;
		}

		private static bool AxisTest_Z0(Vector3 v0, Vector3 v1, Vector3 boxHalfSize, float a, float b, float fa, float fb, out float min, out float max)
		{
			min = default(float);
			max = default(float);
			return false;
		}
	}
}
