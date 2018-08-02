using Newtonsoft.Json;

namespace JiraGitHubIntegration
{
    public class Actor
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("login")]
        public string Login { get; set; }
        [JsonProperty("display_login")]
        public string DisplayLogin { get; set; }
        // [JsonProperty("gravatar_id")]
        // public string GravatarId { get; set; }
        // [JsonProperty("url")]
        // public string Url { get; set; }
        // [JsonProperty("avatar_url")]
        // public string AvatarUrl { get; set; }
    }
}