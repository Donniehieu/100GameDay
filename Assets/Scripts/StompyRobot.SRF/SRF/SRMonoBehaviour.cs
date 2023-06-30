using System.Diagnostics;
using UnityEngine;

namespace SRF
{
	public abstract class SRMonoBehaviour : MonoBehaviour
	{
		private Collider _collider;

		private Transform _transform;

		private Rigidbody _rigidBody;

		private GameObject _gameObject;

		private Rigidbody2D _rigidbody2D;

		private Collider2D _collider2D;

		public Transform CachedTransform
		{
			[DebuggerNonUserCode]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		public Collider CachedCollider
		{
			[DebuggerNonUserCode]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		public Collider2D CachedCollider2D
		{
			[DebuggerNonUserCode]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		public Rigidbody CachedRigidBody
		{
			[DebuggerNonUserCode]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		public Rigidbody2D CachedRigidBody2D
		{
			[DebuggerNonUserCode]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		public GameObject CachedGameObject
		{
			[DebuggerNonUserCode]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		public new Transform transform => null;

		[DebuggerStepThrough]
		[DebuggerNonUserCode]
		protected void AssertNotNull(object value, string fieldName = null)
		{
		}

		[DebuggerStepThrough]
		[DebuggerNonUserCode]
		protected void Assert(bool condition, string message = null)
		{
		}

		[DebuggerStepThrough]
		[DebuggerNonUserCode]
		[Conditional("UNITY_EDITOR")]
		protected void EditorAssertNotNull(object value, string fieldName = null)
		{
		}

		[DebuggerStepThrough]
		[DebuggerNonUserCode]
		[Conditional("UNITY_EDITOR")]
		protected void EditorAssert(bool condition, string message = null)
		{
		}
	}
}
