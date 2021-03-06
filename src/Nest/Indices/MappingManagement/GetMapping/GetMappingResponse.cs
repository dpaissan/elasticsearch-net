﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	[JsonFormatter(typeof(ResolvableDictionaryResponseFormatter<GetMappingResponse, IndexName, IndexMappings>))]
	public class GetMappingResponse : DictionaryResponseBase<IndexName, IndexMappings>
	{
		[IgnoreDataMember]
		public IReadOnlyDictionary<IndexName, IndexMappings> Indices => Self.BackingDictionary;

		public void Accept(IMappingVisitor visitor)
		{
			var walker = new MappingWalker(visitor);
			walker.Accept(this);
		}
	}

	public class IndexMappings
	{
		[Obsolete("Mapping are no longer grouped by type, this indexer is ignored and simply returns Mapppings")]
		public TypeMapping this[string type] => Mappings;

		[DataMember(Name = "mappings")]
		public TypeMapping Mappings { get; internal set; }
	}


	public static class GetMappingResponseExtensions
	{
		public static ITypeMapping GetMappingFor<T>(this GetMappingResponse response) => response.GetMappingFor(typeof(T));

		public static ITypeMapping GetMappingFor(this GetMappingResponse response, IndexName index)
		{
			if (index.IsNullOrEmpty()) return null;

			return response.Indices.TryGetValue(index, out var indexMappings) ? indexMappings.Mappings : null;
		}
	}
}
