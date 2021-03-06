﻿using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	/// <summary>
	/// The kuromoji_stemmer token filter normalizes common katakana spelling variations ending in a
	/// long sound character by removing this character (U+30FC). Only full-width katakana characters are supported.
	/// Part of the `analysis-kuromoji` plugin: https://www.elastic.co/guide/en/elasticsearch/plugins/current/analysis-kuromoji.html
	/// </summary>
	public interface IKuromojiStemmerTokenFilter : ITokenFilter
	{
		/// <summary>
		/// Katakana words shorter than the minimum length are not stemmed (default is 4).
		/// </summary>
		[DataMember(Name ="minimum_length")]
		[JsonFormatter(typeof(NullableStringIntFormatter))]
		int? MinimumLength { get; set; }
	}

	/// <inheritdoc />
	public class KuromojiStemmerTokenFilter : TokenFilterBase, IKuromojiStemmerTokenFilter
	{
		public KuromojiStemmerTokenFilter() : base("kuromoji_stemmer") { }

		/// <inheritdoc />
		public int? MinimumLength { get; set; }
	}

	/// <inheritdoc />
	public class KuromojiStemmerTokenFilterDescriptor
		: TokenFilterDescriptorBase<KuromojiStemmerTokenFilterDescriptor, IKuromojiStemmerTokenFilter>, IKuromojiStemmerTokenFilter
	{
		protected override string Type => "kuromoji_stemmer";

		int? IKuromojiStemmerTokenFilter.MinimumLength { get; set; }

		/// <inheritdoc />
		public KuromojiStemmerTokenFilterDescriptor MinimumLength(int? minimumLength) => Assign(minimumLength, (a, v) => a.MinimumLength = v);
	}
}
