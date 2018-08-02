using Newtonsoft.Json;

namespace JiraGitHubIntegration
{
    public class Repo
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        // [JsonProperty("node_id")]
        // public string NodeId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("full_name")]
        public string FullName { get; set; }
        [JsonProperty("owner")]
        public User Owner { get; set; }
        [JsonProperty("private")]
        public bool Private { get; set; }
        // [JsonProperty("html_url")]
        // public string HtmlUrl { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        // [JsonProperty("fork")]
        // public bool Fork { get; set; }
        // [JsonProperty("url")]
        // public string Url { get; set; }
    }
}