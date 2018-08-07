using Moq;
using Xunit;
using JiraGitHubIntegration.Services;
using JiraGitHubIntegration.GitHubModels;

namespace JiraGitHubIntegration.Tests.Services 
{
    public class JiraIssueKeyNameConventionServiceTest {
        [Fact]
        public void GetIssueKeyFromBranchName_Test()
        {
            // Arrange
            var mockEvent = new Event();
            var jiraIssueKeyConventionSvc = new JiraIssueKeyNameConventionService();
        
            // Act
            var issueKey = jiraIssueKeyConventionSvc.GetIssueKeyFromBranchName(mockEvent);
        
            // Assert
        }
    }
}