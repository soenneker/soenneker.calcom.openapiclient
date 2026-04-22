using Soenneker.Tests.HostedUnit;

namespace Soenneker.CalCom.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CalComOpenApiClientTests : HostedUnitTest
{
    public CalComOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
