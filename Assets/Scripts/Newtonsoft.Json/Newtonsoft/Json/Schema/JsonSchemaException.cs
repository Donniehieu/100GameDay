using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Schema
{
	[Serializable]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class JsonSchemaException : JsonException
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

		public string Path
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public JsonSchemaException()
		{
		}

		public JsonSchemaException(string message)
		{
		}

		public JsonSchemaException(string message, Exception innerException)
		{
		}

		public JsonSchemaException(SerializationInfo info, StreamingContext context)
		{
		}

		internal JsonSchemaException(string message, Exception innerException, string path, int lineNumber, int linePosition)
		{
		}
	}
}
