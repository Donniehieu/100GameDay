using System.Collections.Generic;
using UnityEngine;

namespace Facebook.Unity
{
	public sealed class CustomUpdateContent
	{
		public class CustomUpdateContentBuilder
		{
			private string _contextTokenId;

			private CustomUpdateLocalizedText _text;

			private CustomUpdateLocalizedText _cta;

			private string _image;

			private CustomUpdateMedia _media;

			private string _data;

			public CustomUpdateContentBuilder(string contextTokenId, CustomUpdateLocalizedText text, Texture2D image)
			{
			}

			public CustomUpdateContentBuilder(string contextTokenId, CustomUpdateLocalizedText text, CustomUpdateMedia media)
			{
			}

			public CustomUpdateContentBuilder setCTA(CustomUpdateLocalizedText cta)
			{
				return null;
			}

			public CustomUpdateContentBuilder setData(string data)
			{
				return null;
			}

			public CustomUpdateContent build()
			{
				return null;
			}
		}

		public const string CONTEXT_TOKEN_KEY = "context_token_id";

		public const string CTA_KEY = "cta";

		public const string DATA_KEY = "data";

		public const string DEFAULT_KEY = "default";

		public const string GIF_KEY = "gif";

		public const string IMAGE_KEY = "image";

		public const string LOCALIZATIONS_KEY = "localizations";

		public const string MEDIA_KEY = "media";

		public const string TEXT_KEY = "text";

		public const string URL_KEY = "url";

		public const string VIDEO_KEY = "video";

		private string _contextTokenId;

		private CustomUpdateLocalizedText _text;

		private CustomUpdateLocalizedText _cta;

		private string _image;

		private CustomUpdateMedia _media;

		private string _data;

		private CustomUpdateContent(string contextTokenId, CustomUpdateLocalizedText text, CustomUpdateLocalizedText cta, string image, CustomUpdateMedia media, string data)
		{
		}

		public IDictionary<string, string> toGraphAPIData()
		{
			return null;
		}
	}
}
