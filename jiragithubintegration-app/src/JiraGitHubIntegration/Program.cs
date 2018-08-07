using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using JiraGitHubIntegration.GitHubModels;
using JiraGitHubIntegration.JiraModels;
using JiraGitHubIntegration.Repositories;
using JiraGitHubIntegration.Services;
using Newtonsoft.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly : LambdaSerializer (typeof (Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace JiraGitHubIntegration {

    public class Function {
        private readonly IJiraRepository _jiraRepository;
        private readonly IJiraGitHubUtilityService _jiraGitHubUtilitySvc;

        public Function (IJiraRepository jiraRepository, IJiraGitHubUtilityService jiraGitHubUtilitySvc) {
            _jiraRepository = jiraRepository;
            _jiraGitHubUtilitySvc = jiraGitHubUtilitySvc;
        }

        public APIGatewayProxyResponse FunctionHandler (APIGatewayProxyRequest apigProxyEvent, ILambdaContext context) {
            // deserialize Event payload, payload is PullRequestReviewComment
            var bodyEvent = JsonConvert.DeserializeObject<Event> (apigProxyEvent.Body);

            // get Jira Story Key from branch name convention
            var issueKey = _jiraGitHubUtilitySvc.GetIssueKeyFromBranchName (bodyEvent);

            // get issue from Jira
            var issue = _jiraRepository.GetIssue (issueKey);

            // locally update github code review comment custom field

            // send update to jira
            _jiraRepository.UpdateIssue(issue);

            return new APIGatewayProxyResponse {
                    StatusCode = 200,
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
            };
        }
    }
}