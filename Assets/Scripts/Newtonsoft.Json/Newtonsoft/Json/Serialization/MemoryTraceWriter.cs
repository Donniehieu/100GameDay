using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class MemoryTraceWriter : ITraceWriter
	{
		private readonly Queue<string> _traceMessages;

		private readonly object _lock;

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

		public void Trace(TraceLevel level, string message, Exception? ex)
		{
		}

		public IEnumerable<string> GetTraceMessages()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
