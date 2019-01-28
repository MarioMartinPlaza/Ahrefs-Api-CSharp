namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsRefDomainsNewLost
    {
        [JsonProperty("refdomains", NullValueHandling = NullValueHandling.Ignore)]
        public List<Refdomain> Refdomains { get; set; }
    }

    public partial class RefdomainNewLost : Refdomain
    {
        /// <summary>
        /// Date when the Ahrefs crawler was able to visit new or lost backlinks from the referring domain.
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Indicates whether the backlinks from the referring domain are new or lost.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
              
        [JsonProperty("refdomain_top", NullValueHandling = NullValueHandling.Ignore)]
        public string RefdomainTop { get; set; }

    }
}
