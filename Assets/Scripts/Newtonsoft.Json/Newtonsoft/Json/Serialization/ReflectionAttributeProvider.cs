using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Serialization
{
	public class ReflectionAttributeProvider : IAttributeProvider
	{
		private readonly object _attributeProvider;

		public ReflectionAttributeProvider(object attributeProvider)
		{
		}

		public IList<Attribute> GetAttributes(bool inherit)
		{
			return null;
		}

		public IList<Attribute> GetAttributes(Type attributeType, bool inherit)
		{
			return null;
		}
	}
}
