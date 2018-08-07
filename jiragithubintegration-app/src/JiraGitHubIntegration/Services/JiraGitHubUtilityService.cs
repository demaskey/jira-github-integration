using System;
using JiraGitHubIntegration.GitHubModels;
using JiraGitHubIntegration.JiraModels;

namespace JiraGitHubIntegration.Services {
    public class JiraGitHubUtilityService : IJiraGitHubUtilityService {
        public string GetIssueKeyFromBranchName (Event githubEvent) {
            throw new NotImplementedException ();
        }

        public Issue UpdateJiraIssueWithGitHubCodeReviewComment(Event githubEvent, Issue jiraIssue){
            throw new NotImplementedException();
        }
    }
}