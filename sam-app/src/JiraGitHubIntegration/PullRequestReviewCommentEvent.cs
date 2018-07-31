using Newtonsoft.Json;

namespace JiraGitHubIntegration
{
    public class PullRequestReivewCommentEvent
    {
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("comment")]
        public Comment Comment { get; set; }
        [JsonProperty("pull_request")]
        public PullRequest PullRequest { get; set; }
    }
}