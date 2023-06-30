using System;
using System.Collections.Generic;

namespace BigBear.Core.Runtime.EventManager
{
	public class EventManager
	{
		public delegate void EventDelegate<T>(T e) where T : GameEvent;

		private delegate void EventDelegate(GameEvent e);

		private static EventManager instance;

		private Dictionary<Type, EventDelegate> delegates;

		private Dictionary<Delegate, EventDelegate> delegateLookup;

		public static EventManager Instance => null;

		public int DelegateLookupCount => 0;

		public void AddListener<T>(EventDelegate<T> del) where T : GameEvent
		{
		}

		public void RemoveListener<T>(EventDelegate<T> del) where T : GameEvent
		{
		}

		public void Raise(GameEvent e)
		{
		}

		public void AddListener<T>()
		{
		}
	}
}
