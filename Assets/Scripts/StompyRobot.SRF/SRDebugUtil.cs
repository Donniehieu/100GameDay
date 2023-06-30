using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class SRDebugUtil
{
	public const int LineBufferCount = 512;

	public static bool IsFixedUpdate
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	[DebuggerStepThrough]
	[DebuggerNonUserCode]
	public static void AssertNotNull(object value, string message = null, MonoBehaviour instance = null)
	{
	}

	[DebuggerStepThrough]
	[DebuggerNonUserCode]
	public static void Assert(bool condition, string message = null, MonoBehaviour instance = null)
	{
	}

	[Conditional("UNITY_EDITOR")]
	[DebuggerStepThrough]
	[DebuggerNonUserCode]
	public static void EditorAssertNotNull(object value, string message = null, MonoBehaviour instance = null)
	{
	}

	[DebuggerStepThrough]
	[Conditional("UNITY_EDITOR")]
	[DebuggerNonUserCode]
	public static void EditorAssert(bool condition, string message = null, MonoBehaviour instance = null)
	{
	}
}
