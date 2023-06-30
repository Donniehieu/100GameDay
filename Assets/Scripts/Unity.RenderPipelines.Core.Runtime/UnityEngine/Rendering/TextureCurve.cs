using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	[Serializable]
	[DefaultMember("Item")]
	public class TextureCurve : IDisposable
	{
		private const int k_Precision = 128;

		private const float k_Step = 1f / 128f;

		[SerializeField]
		private bool m_Loop;

		[SerializeField]
		private float m_ZeroValue;

		[SerializeField]
		private float m_Range;

		[SerializeField]
		private AnimationCurve m_Curve;

		private AnimationCurve m_LoopingCurve;

		private Texture2D m_Texture;

		private bool m_IsCurveDirty;

		private bool m_IsTextureDirty;

		public int length
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Keyframe Item => default(Keyframe);

		public TextureCurve(AnimationCurve baseCurve, float zeroValue, bool loop, in Vector2 bounds)
		{
		}

		public TextureCurve(Keyframe[] keys, float zeroValue, bool loop, in Vector2 bounds)
		{
		}

		~TextureCurve()
		{
		}

		[Obsolete("Please use Release() instead.")]
		public void Dispose()
		{
		}

		public void Release()
		{
		}

		[MethodImpl(256)]
		public void SetDirty()
		{
		}

		private static GraphicsFormat GetTextureFormat()
		{
			return default(GraphicsFormat);
		}

		public Texture2D GetTexture()
		{
			return null;
		}

		public float Evaluate(float time)
		{
			return 0f;
		}

		[MethodImpl(256)]
		public int AddKey(float time, float value)
		{
			return 0;
		}

		[MethodImpl(256)]
		public int MoveKey(int index, in Keyframe key)
		{
			return 0;
		}

		[MethodImpl(256)]
		public void RemoveKey(int index)
		{
		}

		[MethodImpl(256)]
		public void SmoothTangents(int index, float weight)
		{
		}
	}
}
