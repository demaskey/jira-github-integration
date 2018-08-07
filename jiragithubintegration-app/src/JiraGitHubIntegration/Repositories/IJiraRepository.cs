using JiraGitHubIntegration.JiraModels;

namespace JiraGitHubIntegration.Repositories {
    public interface IJiraRepository {
        Issue GetIssue (string issueKey);

        void UpdateIssue(Issue issue);
    }
}