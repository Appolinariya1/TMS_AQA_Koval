using System.Net;
using NLog;
using NUnit.Framework.Internal;
using RestSharp;
using RestSharp.Authenticators;
using Logger = NLog.Logger;

namespace RestSharpApi.Tests;

public class TestRailSimpleTest
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    private const string BaseRestUri = "https://aqa2504.testrail.io/";

    [Test]
    public void SimpleGetTest()
    {
        const string endpoint = "index.php?/api/v2/get_user/1";

        var options = new RestClientOptions(BaseRestUri)
        {
            Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")
        };

        //Setup Rest Client
        var client = new RestClient(options);

        //Setup Request
        var request = new RestRequest(endpoint);

        //Execute Request
        var response = client.ExecuteGet(request);

        Logger.Info(response.Content);

        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }

    [Test]
    public void AdvancedGetTest()
    {
        const string endpoint = "index.php?/api/v2/get_user/{user_id}";

        var options = new RestClientOptions(BaseRestUri)
        {
            Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")
        };

        //Setup Rest Client
        var client = new RestClient(options);

        //Setup Request
        var request = new RestRequest(endpoint)
            .AddUrlSegment("user_id", 1);
        
        //Execute Request
        var response = client.ExecuteGet(request);

        Logger.Info(response.Content);

        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }
}