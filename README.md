[![](https://img.shields.io/nuget/v/soenneker.calcom.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.calcom.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.calcom.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.calcom.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.calcom.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.calcom.openapiclient/actions/workflows/codeql.yml)
[![](https://img.shields.io/nuget/dt/soenneker.calcom.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.calcom.openapiclient/)

# Soenneker.CalCom.OpenApiClient

A Kiota-generated .NET client for Cal.com's v1 API.

## Installation

```bash
dotnet add package Soenneker.CalCom.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.CalCom.OpenApiClient;

const string apiKey = "your-api-key";

var adapter = new HttpClientRequestAdapter(new AnonymousAuthenticationProvider());
var client = new CalComOpenApiClient(adapter);

await using Stream? response = await client.Users.GetAsync(config =>
{
    config.QueryParameters.ApiKey = apiKey;
});
```

Cal.com's schema models the API key as a required `apiKey` query parameter, so direct consumers must set it on every operation. For dependency injection and automatic query authentication, use `Soenneker.CalCom.OpenApiClientUtil` instead.

The generated surface follows the source schema. Some operations return `Stream` because their response schema is not defined; dispose those streams after reading them. Regeneration may also change request builders and models when the upstream document changes.
