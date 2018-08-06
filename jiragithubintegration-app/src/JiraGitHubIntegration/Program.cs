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
using JiraGitHubIntegration.JiraModels;
using JiraGitHubIntegration.Repositories;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly : LambdaSerializer (typeof (Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace JiraGitHubIntegration {

    public class Function {
        private readonly IJiraRepository _jiraRepository;

        public Function(IJiraRepository jiraRepository)
        {
            _jiraRepository = jiraRepository;
        }

        public APIGatewayProxyResponse FunctionHandler (APIGatewayProxyRequest apigProxyEvent, ILambdaContext context) {
            // deserialize Event payload
            Event bodyEvent = JsonConvert.DeserializeObject<Event> (apigProxyEvent.Body);

            // get issue from Jira
            Issue issue = _jiraRepository.GetIssue();

            return new APIGatewayProxyResponse {
                Body = JsonConvert.SerializeObject (bodyEvent, Formatting.Indented),
                StatusCode = 200,
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
            };
        }
    }
}