using Newtonsoft.Json;

namespace JiraGitHubIntegration.GitHubModels
{
    public class Commit
    {
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("ref")]
        public string Ref { get; set; }
        [JsonProperty("sha")]
        public string Sha { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("repo")]
        public Repo Repo { get; set; }
    }
}