using JiraGitHubIntegration.JiraModels;

namespace JiraGitHubIntegration.Repositories {
    public class JiraRepository : IJiraRepository {
        public Issue GetIssue () {
            return new Issue();
        }
    }
}