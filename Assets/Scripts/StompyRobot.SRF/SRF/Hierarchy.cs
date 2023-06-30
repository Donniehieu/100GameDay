using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace SRF
{
	[DefaultMember("Item")]
	public class Hierarchy
	{
		private static readonly char[] Seperator;

		private static readonly Dictionary<string, Transform> Cache;

		[Obsolete("Use static Get() instead")]
		public Transform Item => null;

		public static Transform Get(string key)
		{
			return null;
		}
	}
}
