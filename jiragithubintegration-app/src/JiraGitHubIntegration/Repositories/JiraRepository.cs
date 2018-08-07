using System;
using JiraGitHubIntegration.JiraModels;

namespace JiraGitHubIntegration.Repositories {
    public class JiraRepository : IJiraRepository {
        public Issue GetIssue (string issueKey) {
            throw new NotImplementedException ();
        }

        public void UpdateIssue (Issue issue) {
            throw new NotImplementedException ();
        }
    }
}