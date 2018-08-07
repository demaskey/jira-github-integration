using JiraGitHubIntegration.GitHubModels;
using JiraGitHubIntegration.JiraModels;

namespace JiraGitHubIntegration.Services {
    public interface IJiraGitHubUtilityService {
        string GetIssueKeyFromBranchName (Event githubEvent);

        Issue UpdateJiraIssueWithGitHubCodeReviewComment(Event githubEvent, Issue jiraIssue);
    }
}