using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	[Serializable]
	public class JsonReaderException : JsonException
	{
		public int LineNumber
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public int LinePosition
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public string? Path
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public JsonReaderException()
		{
		}

		public JsonReaderException(string message)
		{
		}

		public JsonReaderException(string message, Exception innerException)
		{
		}

		public JsonReaderException(SerializationInfo info, StreamingContext context)
		{
		}

		public JsonReaderException(string message, string path, int lineNumber, int linePosition, Exception? innerException)
		{
		}

		internal static JsonReaderException Create(JsonReader reader, string message)
		{
			return null;
		}

		internal static JsonReaderException Create(JsonReader reader, string message, Exception? ex)
		{
			return null;
		}

		internal static JsonReaderException Create(IJsonLineInfo? lineInfo, string path, string message, Exception? ex)
		{
			return null;
		}
	}
}
