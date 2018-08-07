using JiraGitHubIntegration.GitHubModels;
using JiraGitHubIntegration.Services;
using Moq;
using Xunit;

namespace JiraGitHubIntegration.Tests.Services {
    public class JiraGitHubUtilityServiceTest {
        [Fact]
        public void GetIssueKeyFromBranchName_Test () {
            // Arrange
            var mockEvent = new Event ();
            var jiraIssueKeyConventionSvc = new JiraGitHubUtilityService ();

            // Act
            var issueKey = jiraIssueKeyConventionSvc.GetIssueKeyFromBranchName (mockEvent);

            // Assert
        }
    }
}