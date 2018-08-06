using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;

using JiraGitHubIntegration.GitHubModels;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly : LambdaSerializer (typeof (Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace JiraGitHubIntegration {

    public class Function {

        public APIGatewayProxyResponse FunctionHandler (APIGatewayProxyRequest apigProxyEvent, ILambdaContext context) {

            Event bodyEvent = JsonConvert.DeserializeObject<Event> (apigProxyEvent.Body);

            return new APIGatewayProxyResponse {
                Body = JsonConvert.SerializeObject (bodyEvent, Formatting.Indented),
                StatusCode = 200,
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
            };
        }
    }
}