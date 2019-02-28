﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	/// <summary>
	/// The user_agent processor extracts details from the user agent string a browser sends with its web requests.
	/// This processor adds this information by default under the user_agent field.
	/// The ingest-user-agent plugin ships by default with the regexes.yaml made available by
	/// uap-java with an Apache 2.0 license.
	/// </summary>
	/// <remarks>
	/// Requires the UserAgent Processor Plugin to be installed on the cluster.
	/// </remarks>
	[InterfaceDataContract]
	public interface IUserAgentProcessor : IProcessor
	{
		[DataMember(Name ="field")]
		Field Field { get; set; }

		/// <summary>
		/// If `true` and `field` does not exist, the processor quietly exits without modifying the document
		/// </summary>
		[DataMember(Name ="ignore_missing")]
		bool? IgnoreMissing { get; set; }

		[DataMember(Name ="options")]
		IEnumerable<UserAgentProperty> Properties { get; set; }

		[DataMember(Name ="regex_file")]
		string RegexFile { get; set; }

		[DataMember(Name ="target_field")]
		Field TargetField { get; set; }
	}

	/// <inheritdoc />
	public class UserAgentProcessor : ProcessorBase, IUserAgentProcessor
	{
		/// <inheritdoc />
		public Field Field { get; set; }

		/// <inheritdoc />
		public bool? IgnoreMissing { get; set; }

		/// <inheritdoc />
		public IEnumerable<UserAgentProperty> Properties { get; set; }

		/// <inheritdoc />
		public string RegexFile { get; set; }

		/// <inheritdoc />
		public Field TargetField { get; set; }

		protected override string Name => "user_agent";
	}

	/// <inheritdoc />
	public class UserAgentProcessorDescriptor<T>
		: ProcessorDescriptorBase<UserAgentProcessorDescriptor<T>, IUserAgentProcessor>, IUserAgentProcessor
		where T : class
	{
		protected override string Name => "user_agent";

		Field IUserAgentProcessor.Field { get; set; }
		bool? IUserAgentProcessor.IgnoreMissing { get; set; }
		IEnumerable<UserAgentProperty> IUserAgentProcessor.Properties { get; set; }
		string IUserAgentProcessor.RegexFile { get; set; }
		Field IUserAgentProcessor.TargetField { get; set; }

		/// <inheritdoc />
		public UserAgentProcessorDescriptor<T> Field(Field field) => Assign(a => a.Field = field);

		/// <inheritdoc />
		public UserAgentProcessorDescriptor<T> Field(Expression<Func<T, object>> objectPath) =>
			Assign(a => a.Field = objectPath);

		/// <inheritdoc />
		public UserAgentProcessorDescriptor<T> TargetField(Field field) => Assign(a => a.TargetField = field);

		/// <inheritdoc />
		public UserAgentProcessorDescriptor<T> TargetField(Expression<Func<T, object>> objectPath) =>
			Assign(a => a.TargetField = objectPath);

		/// <inheritdoc />
		public UserAgentProcessorDescriptor<T> RegexFile(string file) => Assign(a => a.RegexFile = file);

		/// <inheritdoc />
		public UserAgentProcessorDescriptor<T> IgnoreMissing(bool? ignoreMissing = true) => Assign(a => a.IgnoreMissing = ignoreMissing);

		/// <inheritdoc />
		public UserAgentProcessorDescriptor<T> Properties(IEnumerable<UserAgentProperty> properties) => Assign(a => a.Properties = properties);

		/// <inheritdoc />
		public UserAgentProcessorDescriptor<T> Properties(params UserAgentProperty[] properties) => Assign(a => a.Properties = properties);
	}
}
