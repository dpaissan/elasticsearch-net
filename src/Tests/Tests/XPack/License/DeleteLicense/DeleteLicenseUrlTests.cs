﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.XPack.License.DeleteLicense
{
	public class DeleteLicenseUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await DELETE("/_license")
			.Fluent(c => c.DeleteLicense())
			.Request(c => c.DeleteLicense(new DeleteLicenseRequest()))
			.FluentAsync(c => c.DeleteLicenseAsync())
			.RequestAsync(c => c.DeleteLicenseAsync(new DeleteLicenseRequest()));
	}
}
