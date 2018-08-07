using JiraGitHubIntegration.GitHubModels;

namespace JiraGitHubIntegration.Services {
    public interface IJiraGitHubUtilityService {
        string GetIssueKeyFromBranchName (Event githubEvent);
    }
}