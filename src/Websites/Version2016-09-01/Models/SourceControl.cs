// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The source control OAuth token.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SourceControl : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the SourceControl class.
        /// </summary>
        public SourceControl()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SourceControl class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="sourceControlName">Name or source control
        /// type.</param>
        /// <param name="token">OAuth access token.</param>
        /// <param name="tokenSecret">OAuth access token secret.</param>
        /// <param name="refreshToken">OAuth refresh token.</param>
        /// <param name="expirationTime">OAuth token expiration.</param>
        public SourceControl(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string sourceControlName = default(string), string token = default(string), string tokenSecret = default(string), string refreshToken = default(string), System.DateTime? expirationTime = default(System.DateTime?))
            : base(id, name, kind, type)
        {
            SourceControlName = sourceControlName;
            Token = token;
            TokenSecret = tokenSecret;
            RefreshToken = refreshToken;
            ExpirationTime = expirationTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name or source control type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string SourceControlName { get; set; }

        /// <summary>
        /// Gets or sets oAuth access token.
        /// </summary>
        [JsonProperty(PropertyName = "properties.token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets oAuth access token secret.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tokenSecret")]
        public string TokenSecret { get; set; }

        /// <summary>
        /// Gets or sets oAuth refresh token.
        /// </summary>
        [JsonProperty(PropertyName = "properties.refreshToken")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets oAuth token expiration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationTime")]
        public System.DateTime? ExpirationTime { get; set; }

    }
}
