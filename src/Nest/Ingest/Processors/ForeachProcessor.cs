﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	[InterfaceDataContract]
	public interface IForeachProcessor : IProcessor
	{
		[DataMember(Name ="field")]
		Field Field { get; set; }

		[DataMember(Name ="processor")]
		IProcessor Processor { get; set; }
	}

	public class ForeachProcessor : ProcessorBase, IForeachProcessor
	{
		public Field Field { get; set; }
		public IProcessor Processor { get; set; }
		protected override string Name => "foreach";
	}

	public class ForeachProcessorDescriptor<T>
		: ProcessorDescriptorBase<ForeachProcessorDescriptor<T>, IForeachProcessor>, IForeachProcessor
		where T : class
	{
		protected override string Name => "foreach";

		Field IForeachProcessor.Field { get; set; }

		IProcessor IForeachProcessor.Processor { get; set; }

		public ForeachProcessorDescriptor<T> Field(Field field) => Assign(field, (a, v) => a.Field = v);

		public ForeachProcessorDescriptor<T> Field(Expression<Func<T, object>> objectPath) =>
			Assign(objectPath, (a, v) => a.Field = v);

		public ForeachProcessorDescriptor<T> Processor(Func<ProcessorsDescriptor, IPromise<IList<IProcessor>>> selector) =>
			Assign(selector, (a, v) => a.Processor = v?.Invoke(new ProcessorsDescriptor())?.Value?.FirstOrDefault());
	}
}
