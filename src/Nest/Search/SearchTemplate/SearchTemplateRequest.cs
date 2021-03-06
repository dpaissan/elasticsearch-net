﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nest
{
	[ReadAs(typeof(SearchTemplateRequest))]
	public partial interface ISearchTemplateRequest : ICovariantSearchRequest
	{
		[DataMember(Name ="id")]
		string Id { get; set; }

		[DataMember(Name ="params")]
		IDictionary<string, object> Params { get; set; }

		[DataMember(Name ="source")]
		string Source { get; set; }
	}

	public partial class SearchTemplateRequest
	{
		public string Id { get; set; }

		public IDictionary<string, object> Params { get; set; }

		public string Source { get; set; }
		protected Type ClrType { get; set; }
		Type ICovariantSearchRequest.ClrType => ClrType;

		protected sealed override void Initialize() => TypedKeys = true;
	}

	public class SearchTemplateRequest<T> : SearchTemplateRequest
		where T : class
	{
		public SearchTemplateRequest() : base(typeof(T)) => ClrType = typeof(T);

		public SearchTemplateRequest(Indices indices) : base(indices) => ClrType = typeof(T);
	}

	public partial class SearchTemplateDescriptor<T> where T : class
	{
		/// <summary>
		/// Whether conditionless queries are allowed or not
		/// </summary>
		internal bool _Strict { get; set; }

		Type ICovariantSearchRequest.ClrType => typeof(T);

		string ISearchTemplateRequest.Id { get; set; }

		IDictionary<string, object> ISearchTemplateRequest.Params { get; set; }

		string ISearchTemplateRequest.Source { get; set; }

		protected sealed override void Initialize() => TypedKeys();

		public SearchTemplateDescriptor<T> Source(string template) => Assign(template, (a, v) => a.Source = v);

		public SearchTemplateDescriptor<T> Id(string id) => Assign(id, (a, v) => a.Id = v);

		public SearchTemplateDescriptor<T> Params(Dictionary<string, object> paramDictionary) => Assign(paramDictionary, (a, v) => a.Params = v);

		public SearchTemplateDescriptor<T> Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> paramDictionary) =>
			Assign(paramDictionary, (a, v) => a.Params = v?.Invoke(new FluentDictionary<string, object>()));
	}
}
