using System.Collections.Generic;

namespace Facebook.Unity
{
	public sealed class CustomUpdateLocalizedText
	{
		private string _default;

		private IDictionary<string, string> _localizations;

		public CustomUpdateLocalizedText(string defaultText, IDictionary<string, string> localizations)
		{
		}

		public string toJson()
		{
			return null;
		}
	}
}
