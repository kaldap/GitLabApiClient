using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Projects.Responses
{
    public sealed class Commit
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("short_id")]
        public string ShortId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("author_email")]
        public string AuthorEmail { get; set; }

        [JsonProperty("authored_date")]
        public DateTime AuthoredDate { get; set; }

        [JsonProperty("committer_name")]
        public string CommiterName { get; set; }

        [JsonProperty("committer_email")]
        public string CommiterEmail { get; set; }

        [JsonProperty("committed_date")]
        public DateTime CommitedDate { get; set; }

        [JsonProperty("created_at")]
        public DateTime ImportError { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("parent_ids")]
        public List<string> ParentIds { get; } = new List<string>();
    }
}
