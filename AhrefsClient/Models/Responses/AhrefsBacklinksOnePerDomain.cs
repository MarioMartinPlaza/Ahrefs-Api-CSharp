namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsBacklinksOnePerDomain
    {
        [JsonProperty("refpages", NullValueHandling = NullValueHandling.Ignore)]
        public List<RefpagePerDomain> Refpages { get; set; }
    }

    public partial class RefpagePerDomain : Refpage
    {
        /// <summary>
        /// Total number of backlinks from this referring domain.
        /// </summary>
        [JsonProperty("total_backlinks", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalBacklinks { get; set; }
    }  
}
