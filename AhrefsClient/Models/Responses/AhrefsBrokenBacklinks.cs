namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsBrokenBacklinks
    {
        [JsonProperty("refpages", NullValueHandling = NullValueHandling.Ignore)]
        public List<RefpageBrokenLinks> Refpages { get; set; }
    }

    public partial class RefpageBrokenLinks : Refpage
    {
        /// <summary>
        /// The date when the Ahrefs crawler thinks the link became broken.
        /// </summary>
        [JsonProperty("broken_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? BrokenAt { get; set; }

        /// <summary>
        /// The string indicating the nature of error (currently only "dns").
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }
    }
}
