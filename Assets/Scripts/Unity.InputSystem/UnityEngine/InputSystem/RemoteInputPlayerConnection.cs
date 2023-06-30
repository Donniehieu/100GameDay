using System;
using UnityEngine.Networking.PlayerConnection;

namespace UnityEngine.InputSystem
{
	[Serializable]
	internal class RemoteInputPlayerConnection : ScriptableObject, IObserver<InputRemoting.Message>, IObservable<InputRemoting.Message>
	{
		private class Subscriber : IDisposable
		{
			public RemoteInputPlayerConnection owner;

			public IObserver<InputRemoting.Message> observer;

			public void Dispose()
			{
			}
		}

		public static readonly Guid kNewDeviceMsg;

		public static readonly Guid kNewLayoutMsg;

		public static readonly Guid kNewEventsMsg;

		public static readonly Guid kRemoveDeviceMsg;

		public static readonly Guid kChangeUsagesMsg;

		public static readonly Guid kStartSendingMsg;

		public static readonly Guid kStopSendingMsg;

		[SerializeField]
		private IEditorPlayerConnection m_Connection;

		[NonSerialized]
		private Subscriber[] m_Subscribers;

		[SerializeField]
		private int[] m_ConnectedIds;

		public void Bind(IEditorPlayerConnection connection, bool isConnected)
		{
		}

		public IDisposable Subscribe(IObserver<InputRemoting.Message> observer)
		{
			return null;
		}

		private void OnConnected(int id)
		{
		}

		private void OnDisconnected(int id)
		{
		}

		private void OnNewDevice(MessageEventArgs args)
		{
		}

		private void OnNewLayout(MessageEventArgs args)
		{
		}

		private void OnNewEvents(MessageEventArgs args)
		{
		}

		private void OnRemoveDevice(MessageEventArgs args)
		{
		}

		private void OnChangeUsages(MessageEventArgs args)
		{
		}

		private void OnStartSending(MessageEventArgs args)
		{
		}

		private void OnStopSending(MessageEventArgs args)
		{
		}

		private void SendToSubscribers(InputRemoting.MessageType type, MessageEventArgs args)
		{
		}

		private void System_002EIObserver_003CUnityEngine_002EInputSystem_002EInputRemoting_002EMessage_003E_002EOnNext(InputRemoting.Message msg)
		{
		}

		private void System_002EIObserver_003CUnityEngine_002EInputSystem_002EInputRemoting_002EMessage_003E_002EOnError(Exception error)
		{
		}

		private void System_002EIObserver_003CUnityEngine_002EInputSystem_002EInputRemoting_002EMessage_003E_002EOnCompleted()
		{
		}
	}
}
