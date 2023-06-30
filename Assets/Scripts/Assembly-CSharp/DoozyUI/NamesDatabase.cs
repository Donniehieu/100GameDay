using System;
using System.Collections.Generic;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class NamesDatabase : ScriptableObject
	{
		public bool isDirty;

		public List<string> data;

		public int Count => 0;

		public bool IsEmpty => false;

		public bool IsNull => false;

		public void Init()
		{
		}

		public void Add(string name)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(string name)
		{
			return false;
		}

		public string GetName(int index)
		{
			return null;
		}

		public int IndexOf(string name)
		{
			return 0;
		}

		public void Remove(string name)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void Reverse()
		{
		}

		public void Sort()
		{
		}

		public void RemoveEmpty()
		{
		}

		public string[] ToArray()
		{
			return null;
		}
	}
}
