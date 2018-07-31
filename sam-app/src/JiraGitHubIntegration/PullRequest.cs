using System;
using Newtonsoft.Json;

namespace JiraGitHubIntegration {
    public class PullRequest {
        [JsonProperty ("tilte")]
        public string Title { get; set; }

        [JsonProperty ("user")]
        public User User { get; set; }

        [JsonProperty ("body")]
        public string Body { get; set; }

        [JsonProperty ("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}