namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsBacklinksNewLost
    {
        [JsonProperty("refpages", NullValueHandling = NullValueHandling.Ignore)]
        public List<RefpageNewLost> Refpages { get; set; }
    }

    public partial class RefpageNewLost : Refpage
    {
        /// <summary>
        /// Date the backlink was tagged as New or Lost
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Indicates whether the backlink is New or Lost.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Either "fresh", "drop", or "recrawl".
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public string Origin { get; set; }       
    }   
}
