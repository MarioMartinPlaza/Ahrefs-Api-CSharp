namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsLinkedDomains
    {
        [JsonProperty("domains", NullValueHandling = NullValueHandling.Ignore)]
        public List<Domain> Domains { get; set; }
    }

    public partial class Domain
    {
        /// <summary>
        /// Target of the request.
        /// </summary>
        [JsonProperty("domain_from", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainFrom { get; set; }

        /// <summary>
        /// External domain that has links from the target.
        /// </summary>
        [JsonProperty("domain_to", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainTo { get; set; }

        /// <summary>
        /// Number of external links from the target that link to the external domain.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public long? Links { get; set; }

        /// <summary>
        /// Number of unique pages from the target that link to the external domain.
        /// </summary>
        [JsonProperty("unique_pages", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniquePages { get; set; }

        /// <summary>
        /// Domain Rating of the external domain.
        /// </summary>
        [JsonProperty("domain_to_rating", NullValueHandling = NullValueHandling.Ignore)]
        public long? DomainToRating { get; set; }

        /// <summary>
        /// Ahrefs rank of the external domain.
        /// </summary>
        [JsonProperty("domain_to_ahrefs_top", NullValueHandling = NullValueHandling.Ignore)]
        public long? DomainToAhrefsTop { get; set; }
    }
}
