using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.CalCom.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class CalComOpenApiClientTests : FixturedUnitTest
{
    public CalComOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
