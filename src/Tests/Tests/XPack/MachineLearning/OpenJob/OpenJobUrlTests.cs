﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.XPack.MachineLearning.OpenJob
{
	public class OpenJobUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await POST("/_ml/anomaly_detectors/job_id/_open")
			.Fluent(c => c.OpenJob("job_id"))
			.Request(c => c.OpenJob(new OpenJobRequest("job_id")))
			.FluentAsync(c => c.OpenJobAsync("job_id"))
			.RequestAsync(c => c.OpenJobAsync(new OpenJobRequest("job_id")));
	}
}
