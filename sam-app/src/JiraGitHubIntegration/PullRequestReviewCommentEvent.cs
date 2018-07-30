namespace JiraGitHubIntegration
{
    public class PullRequestReivewComment
    {
        public string action { get; set; }
        public Comment comment { get; set; }
        public PullRequest pull_request { get; set; }
    }
}