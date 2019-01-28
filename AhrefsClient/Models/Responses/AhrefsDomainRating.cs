namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsDomainRating
    {
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public Domain Domain { get; set; }
    }

    public partial class Domain
    {
        /// <summary>
        /// Domain Rating of the target domain.
        /// </summary>
        [JsonProperty("domain_rating", NullValueHandling = NullValueHandling.Ignore)]
        public long? DomainRating { get; set; }

        /// <summary>
        /// Ahrefs Rank of the target domain.
        /// </summary>
        [JsonProperty("ahrefs_top", NullValueHandling = NullValueHandling.Ignore)]
        public long? AhrefsTop { get; set; }
    }   
}
