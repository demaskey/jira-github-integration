using Newtonsoft.Json;

namespace JiraGitHubIntegration
{
    public class Event
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("public")]
        public bool Public { get; set; }
        [JsonProperty("payload")]
        public PullRequestReivewCommentEvent Payload { get; set; }
        // public string Repo { get; set; }
        // public string Actor { get; set; }
        // public string Org { get; set; }
        // public string Created_At { get; set; }
        // public string Id { get; set; }
    }
}