using Newtonsoft.Json;
using System;

namespace JiraGitHubIntegration
{
    public class Comment
    {
        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}