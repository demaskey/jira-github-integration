using System;
using Newtonsoft.Json;

namespace JiraGitHubIntegration
{
    public class Event
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("actor")]
        public Actor Actor { get; set; }
        [JsonProperty("repo")]
        public Repo Repo { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }
        [JsonProperty("payload")]
        public PullRequestReviewCommentEvent Payload { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}