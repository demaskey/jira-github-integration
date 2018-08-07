using JiraGitHubIntegration.GitHubModels;
using JiraGitHubIntegration.JiraModels;
using JiraGitHubIntegration.Services;
using Moq;
using Xunit;

namespace JiraGitHubIntegration.Tests.Services {
    public class JiraGitHubUtilityServiceTest {
        [Fact]
        public void GetIssueKeyFromBranchName_Test () {
            // Arrange
            var mockEvent = new Event ();
            var jiraGitHubUtilitySvc = new JiraGitHubUtilityService ();

            // Act
            var issueKey = jiraGitHubUtilitySvc.GetIssueKeyFromBranchName (mockEvent);

            // Assert
        }

        [Fact]
        public void UpdateJiraIssueWithGitHubCodeReviewComment_Test () {
            // Arrange

            var jiraGitHubUtilitySvc = new JiraGitHubUtilityService ();

            var mockGitHubEvent = new Event ();
            var mockJiraIssue = new Issue ();

            // Act
            var updatedIssue = jiraGitHubUtilitySvc.UpdateJiraIssueWithGitHubCodeReviewComment (mockGitHubEvent, mockJiraIssue);

            // Assert
        }
    }
}