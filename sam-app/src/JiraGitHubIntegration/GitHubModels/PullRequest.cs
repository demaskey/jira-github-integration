using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JiraGitHubIntegration.GitHubModels {
    public class PullRequest {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        // [JsonProperty("node_id")]
        // public string NodeId { get; set; }
        // [JsonProperty("html_url")]
        // public string HtmlUrl { get; set; }
        [JsonProperty("diff_url")]
        public string DiffUrl { get; set; }
        [JsonProperty("patch_url")]
        public string PatchUrl { get; set; }
        // [JsonProperty("issue_url")]
        // public string IssueUrl { get; set; }
        [JsonProperty("number")]
        public int Number { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("locked")]
        public bool Locked { get; set; }
        [JsonProperty ("tilte")]
        public string Title { get; set; }
        [JsonProperty ("user")]
        public User User { get; set; }
        [JsonProperty ("body")]
        public string Body { get; set; }
        [JsonProperty ("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty ("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty ("closed_at")]
        public DateTime? ClosedAt { get; set; }
        [JsonProperty ("merged_at")]
        public DateTime? MergedAt { get; set; }
        // [JsonProperty("merge_commit_sha")]
        // public string MergeCommitSha { get; set; }
        [JsonProperty("assignee")]
        public User Assignee { get; set; }
        [JsonProperty("assignees")]
        public ICollection<User> Assignees { get; set; }
        [JsonProperty("requestetd_reviewers")]
        public ICollection<User> RequestedReviewers { get; set; }
        [JsonProperty("requested_teams")]
        public ICollection<string> RequestedTeams { get; set; }
        // [JsonProperty("labels")]
        // public ICollection<string> Labels { get; set; }
        // [JsonProperty("milestone")]
        // public object Milestone { get; set; }
        [JsonProperty("commits_url")]
        public string CommitsUrl { get; set; }
        [JsonProperty("review_comments_url")]
        public string ReviewCommentsUrl { get; set; }
        [JsonProperty("review_comment_url")]
        public string ReviewCommentUrl { get; set; }
        [JsonProperty("comments_url")]
        public string CommentsUrl { get; set; }
        [JsonProperty("statuses_url")]
        public string StatusesUrl { get; set; }
        [JsonProperty("head")]
        public Commit Head { get; set; }
        [JsonProperty("base")]
        public Commit Base { get; set; }
        // [JsonProperty("author_association")]
        // public string AuthorAssociation { get; set; }
    }
}