using Newtonsoft.Json;

namespace JiraGitHubIntegration
{
    public class PullRequestReviewCommentEvent
    {
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("comment")]
        public Comment Comment { get; set; }
        [JsonProperty("pull_request")]
        public PullRequest PullRequest { get; set; }
    }
}