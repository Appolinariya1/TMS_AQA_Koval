using Allure.NUnit;
using NLog;
using TestRailComplexApi.Clients;
using TestRailComplexApi.Services;

namespace TestRailComplexApi.Tests.API;

[Parallelizable(scope: ParallelScope.Fixtures)]
[AllureNUnit]
public class BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    protected ProjectService? ProjectService;

    [OneTimeSetUp]
    public void SetupApi()
    {
        var restClient = new RestClientExtended();

        ProjectService = new ProjectService(restClient);
    }
}