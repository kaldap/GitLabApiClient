using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Projects.Responses
{
    public sealed class Release
    {
        [JsonProperty("tag_name")]
        public string TagName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
