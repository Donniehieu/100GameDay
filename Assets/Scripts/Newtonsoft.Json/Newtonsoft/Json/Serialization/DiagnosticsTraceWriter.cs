using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class DiagnosticsTraceWriter : ITraceWriter
	{
		public TraceLevel LevelFilter
		{
			[CompilerGenerated]
			get
			{
				return default(TraceLevel);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private TraceEventType GetTraceEventType(TraceLevel level)
		{
			return default(TraceEventType);
		}

		public void Trace(TraceLevel level, string message, Exception? ex)
		{
		}
	}
}
