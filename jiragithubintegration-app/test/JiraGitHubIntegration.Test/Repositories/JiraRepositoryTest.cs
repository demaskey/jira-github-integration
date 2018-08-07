using JiraGitHubIntegration.JiraModels;
using JiraGitHubIntegration.Repositories;
using Moq;
using Xunit;

namespace JiraGitHubIntegration.Tests.Repositories {
    public class JiraRepositoryTest {
        [Fact]
        public void GetIssue_Test () {
            // Arrange
            var jiraRepo = new JiraRepository ();
            var mockIssueKey = "MAC-1234";

            // Act
            var issue = jiraRepo.GetIssue (mockIssueKey);

            // Assert
            Assert.NotNull (issue);
        }

        [Fact]
        public void UpdateIssue_Test()
        {
            // Arrage
            var mockIssue = new Issue();
            var jiraRepo = new JiraRepository();
        
            // Act
            jiraRepo.UpdateIssue(mockIssue);
        
            // Assert
        }
    }
}