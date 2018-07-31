using Newtonsoft.Json;

namespace JiraGitHubIntegration
{
    public class User
    {
        [JsonProperty("login")]
        public string Login { get; set; }
    }
}