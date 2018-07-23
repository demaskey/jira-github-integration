using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

using Newtonsoft.Json;
using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using Amazon.Lambda.APIGatewayEvents;

namespace JiraGitHubIntegration.Tests
{
  public class FunctionTest
  {
    [Fact]
    public void FunctionHandler_Post_ReturnBody_Test()
    {
      // arrange
      TestLambdaContext context;
      APIGatewayProxyRequest request;
      APIGatewayProxyResponse response;

      Dictionary<string, string> body = new Dictionary<string, string>
      {
          { "message", "hello Mr. Hunt!" },
          { "location", "" },
      };

      request = new APIGatewayProxyRequest();
      request.HttpMethod = "post";
      request.Body = JsonConvert.SerializeObject(body);
      context = new TestLambdaContext();
      

      var ExpectedResponse = new APIGatewayProxyResponse
      {
          Body = JsonConvert.SerializeObject(body),
          StatusCode = 200,
          Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
      };

      // act
      var function = new Function();
      response = function.FunctionHandler(request, context);

      Console.WriteLine("Lambda Response: \n" + response.Body);
      Console.WriteLine("Expected Response: \n" + ExpectedResponse.Body);

      // assert
      Assert.Equal(ExpectedResponse.StatusCode, response.StatusCode);
      Assert.Equal(ExpectedResponse.Body, response.Body);
      Assert.Equal(ExpectedResponse.Headers, response.Headers);
    }

    [Fact]
    public void FunctionHandler_Get_Return405_Test()
    {
      // arrange
      Dictionary<string, string> body = new Dictionary<string, string>
      {
          { "message", "hello Mr. Hunt!" },
          { "location", "" },
      };
      var request = new APIGatewayProxyRequest();
      request.HttpMethod = "get";
      request.Body = JsonConvert.SerializeObject(body);

      var context = new TestLambdaContext();

      var expectedResponseBody = new Dictionary<string, string>
      {
        { "message", "Method Not Allowed" }
      };

      var expectedResponse = new APIGatewayProxyResponse
      {
        Body = JsonConvert.SerializeObject(expectedResponseBody),
        StatusCode = 405,
        Headers = new Dictionary<string, string>
        {
          { "Content-Type", "application/json" },
          { "Allow", "post" }
        }
      };

      // act
      var function = new Function();
      APIGatewayProxyResponse response = function.FunctionHandler(request, context);

      // assert
      Assert.Equal(expectedResponse.Body, response.Body);
      Assert.Equal(expectedResponse.StatusCode, response.StatusCode);
      Assert.Equal(expectedResponse.Headers, response.Headers);
    }
  }
}
