using Newtonsoft.Json;
using System;

namespace JiraGitHubIntegration.GitHubModels
{
    public class Comment
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("pull_request_review_id")]
        public int PullRequestReviewId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        // [JsonProperty("node_id")]
        // public string NodeId { get; set; }
        [JsonProperty("diff_hunk")]
        public string DiffHunk { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("position")]
        public int Position { get; set; }
        [JsonProperty("original_position")]
        public int OriginalPosition { get; set; }
        [JsonProperty("commit_id")]
        public string CommitId { get; set; }
        [JsonProperty("original_commit_id")]
        public string OriginalCommitId { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        // [JsonProperty("html_url")]
        // public string HtmlUrl { get; set; }
        [JsonProperty("pull_request_url")]
        public string PullRequestUrl { get; set; }
        // [JsonProperty("author_association")]
        // public string AuthorAssociation { get; set; }
    }
}