using JiraGitHubIntegration.GitHubModels;

namespace JiraGitHubIntegration.Services {
    public interface IJiraIssueKeyNameConventionService {
        string GetIssueKeyFromBranchName (Event githubEvent);
    }
}