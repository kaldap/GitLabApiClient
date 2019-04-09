using System.Collections.Generic;
using GitLabApiClient.Internal.Utilities;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Projects.Requests
{
    /// <summary>
    /// Used to create tagss in a project.
    /// </summary>
    public sealed class CreateProjectTagRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectTagRequest"/> class.
        /// </summary>
        /// <param name="projectId">The ID or URL-encoded path of the project owned by the authenticated user.</param>
        /// <param name="name">Name of the tag.</param>
        /// <param name="refName">Reference commit name (SHA, another tag or branch) of the tag.</param>
        public CreateProjectTagRequest(string projectId, string name, string refName)
        {
            Guard.NotEmpty(projectId, nameof(projectId));
            Guard.NotEmpty(refName, nameof(refName));
            Guard.NotEmpty(name, nameof(name));
            ProjectId = projectId;
            TagName = name;
            Ref = refName;
        }

        /// <summary>
        /// The ID or URL-encoded path of the project owned by the authenticated user.
        /// </summary>
        [JsonProperty("id")]
        public string ProjectId { get; private set; }

        /// <summary>
        /// The name of the tag.
        /// </summary>
        [JsonProperty("tag_name")]
        public string TagName { get; private set; }

        /// <summary>
        /// Reference commit name (SHA, another tag or branch) of the tag.
        /// </summary>
        [JsonProperty("ref")]
        public string Ref { get; set; }

        /// <summary>
        /// The description of the tag.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// The priority of the label. Must be greater or equal than zero or null to remove the priority.
        /// </summary>
        [JsonProperty("release_description")]
        public string ReleaseDescription { get; set; }
    }
}
