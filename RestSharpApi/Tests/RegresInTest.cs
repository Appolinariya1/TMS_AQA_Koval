using System.Net;
using NLog;
using NUnit.Framework.Internal;
using RestSharp;
using Logger = NLog.Logger;

namespace RestSharpApi.Tests;

public class RegresInTest
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    private const string BaseRestUri = "https://reqres.in/";
    
    [Test]
    public void SimpleGetTest()
    {
        const string endpoint = "/api/users/2";
        //const string endpoint = "/api/users/23"; //404 Not Found
        
        //Setup Rest Client
        var client = new RestClient(BaseRestUri);
        
        //Setup Request
        var request = new RestRequest(endpoint);
        
        //Execute Request
        var response = client.ExecuteGet(request);
        
        Logger.Info(response.Content);
        
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }
    
    [Test]
    public void SimplePostTest()
    {
        const string endpoint = "/api/users"; 
        
        //Setup Rest Client
        var client = new RestClient(BaseRestUri);
        
        //Setup Request
        var request = new RestRequest(endpoint);
        request.AddJsonBody("{\"name\": \"morpheus\",\"job\": \"leader\"}");
        
        //Execute Request
        var response = client.ExecutePost(request);
        
        Logger.Info(response.Content);
        
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
    }
}