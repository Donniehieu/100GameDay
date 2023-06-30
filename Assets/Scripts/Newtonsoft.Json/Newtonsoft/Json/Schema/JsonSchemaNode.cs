using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Schema
{
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaNode
	{
		public string Id
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ReadOnlyCollection<JsonSchema> Schemas
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Dictionary<string, JsonSchemaNode> Properties
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Dictionary<string, JsonSchemaNode> PatternProperties
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public List<JsonSchemaNode> Items
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public JsonSchemaNode AdditionalProperties
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public JsonSchemaNode AdditionalItems
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public JsonSchemaNode(JsonSchema schema)
		{
		}

		private JsonSchemaNode(JsonSchemaNode source, JsonSchema schema)
		{
		}

		public JsonSchemaNode Combine(JsonSchema schema)
		{
			return null;
		}

		public static string GetId(IEnumerable<JsonSchema> schemata)
		{
			return null;
		}
	}
}
