using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using JiraGitHubIntegration.GitHubModels;
using JiraGitHubIntegration.JiraModels;
using JiraGitHubIntegration.Repositories;
using Moq;
using Newtonsoft.Json;
using Xunit;
using JiraGitHubIntegration.Services;

namespace JiraGitHubIntegration.Tests {
    public class FunctionTest {
        [Fact]
        public void FunctionHandler_Post_ReturnBody_Test () {
            // arrange
            TestLambdaContext context;
            APIGatewayProxyRequest request;
            APIGatewayProxyResponse response;

            Event body = new Event {
                Type = "PullRequestReviewCommentEvent",
                Public = true,
                Payload = new PullRequestReviewCommentEvent {
                Action = "created",
                Comment = new Comment {
                User = new User {
                Login = "octocat"
                },
                Body = "Maybe you should use more emojji on this line.",
                CreatedAt = DateTime.Parse ("2018-05-30T20:18:31Z")
                },
                PullRequest = new PullRequest {
                Title = "Update the README with new information",
                User = new User {
                Login = "Codertocat"
                },
                Body = "This is a pretty simple change that we need to pull into master.",
                CreatedAt = DateTime.Parse ("2018-05-30T20:18:30Z")
                }
                }
            };

            request = new APIGatewayProxyRequest ();
            request.HttpMethod = "post";
            request.Body = JsonConvert.SerializeObject (body, Formatting.Indented);
            context = new TestLambdaContext ();

            var mockJiraIssueKey = "MAC-1234";
            var mockJiraIssueKeyNameConventionSvc = new Mock<IJiraGitHubUtilityService>();
            mockJiraIssueKeyNameConventionSvc.Setup(x=>x.GetIssueKeyFromBranchName(It.IsAny<Event>())).Returns(mockJiraIssueKey);

            var mockJiraRepo = new Mock<IJiraRepository> ();
            var mockJiraIssue = new Issue ();
            mockJiraRepo.Setup (x => x.GetIssue (mockJiraIssueKey)).Returns (mockJiraIssue);
            mockJiraRepo.Setup(x=>x.UpdateIssue(mockJiraIssue));

            var function = new Function (mockJiraRepo.Object, mockJiraIssueKeyNameConventionSvc.Object);

             var ExpectedResponse = new APIGatewayProxyResponse {
                StatusCode = 200,
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
            };

            // act

            response = function.FunctionHandler (request, context);

            Console.WriteLine ("Lambda Response: \n" + response.Body);
            Console.WriteLine ("Expected Response: \n" + ExpectedResponse.Body);

            // assert
            mockJiraIssueKeyNameConventionSvc.Verify(x=>x.GetIssueKeyFromBranchName(It.IsAny<Event>()), Times.Once());
            mockJiraRepo.Verify (x => x.GetIssue (mockJiraIssueKey), Times.Once());
            mockJiraRepo.Verify(x=>x.UpdateIssue(mockJiraIssue), Times.Once());

            Assert.Equal (ExpectedResponse.StatusCode, response.StatusCode);
            Assert.Equal (ExpectedResponse.Body, response.Body);
            Assert.Equal (ExpectedResponse.Headers, response.Headers);
        }
    }
}