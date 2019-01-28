namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsBacklinksNewLostCounters
    {
        [JsonProperty("counts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Count> Counts { get; set; }
    }

    public partial class Count
    {
        /// <summary>
        /// Date the backlink was tagged as New or Lost
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        /// <summary>
        /// URL of the page the backlink is pointing to.
        /// </summary>
        [JsonProperty("url_to", NullValueHandling = NullValueHandling.Ignore)]
        public Uri UrlTo { get; set; }

        /// <summary>
        /// Total number of new backlinks found to this url.
        /// </summary>
        [JsonProperty("new", NullValueHandling = NullValueHandling.Ignore)]
        public long? New { get; set; }

        /// <summary>
        /// Total number of backlinks removed to this url.
        /// </summary>
        [JsonProperty("lost", NullValueHandling = NullValueHandling.Ignore)]
        public long? Lost { get; set; }

        /// <summary>
        /// Total number of new backlinks found to this url when ignoring where filter.
        /// </summary>
        [JsonProperty("new_total", NullValueHandling = NullValueHandling.Ignore)]
        public long? NewTotal { get; set; }

        /// <summary>
        /// Total number of backlinks removed to this url when ignoring where filter.
        /// </summary>
        [JsonProperty("lost_total", NullValueHandling = NullValueHandling.Ignore)]
        public long? LostTotal { get; set; }
    }
}
