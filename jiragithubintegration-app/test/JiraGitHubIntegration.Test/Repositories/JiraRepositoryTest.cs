using Xunit;
using Moq;

using JiraGitHubIntegration.Repositories;
using JiraGitHubIntegration.JiraModels;

namespace JiraGitHubIntegration.Test.Repositories
{
    public class JiraRepositoryTest {
        [Fact]
        public void GetIssue_Test()
        {
            // Arrange
            var jiraRepo = new JiraRepository();
            
            // Act
            var issue = jiraRepo.GetIssue();
            
            // Assert
            Assert.NotNull(issue);
        }
    }
}