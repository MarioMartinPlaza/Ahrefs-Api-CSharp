namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsRefips
    {
        [JsonProperty("refips", NullValueHandling = NullValueHandling.Ignore)]
        public List<Refip> Refips { get; set; }
    }

    public partial class Refip
    {
        /// <summary>
        /// The referring IP address that links to the target.
        /// </summary>
        [JsonProperty("refip", NullValueHandling = NullValueHandling.Ignore)]
        public string RefipRefip { get; set; }

        /// <summary>
        /// The domain name for the referring IP address.
        /// </summary>
        [JsonProperty("refdomain", NullValueHandling = NullValueHandling.Ignore)]
        public string Refdomain { get; set; }

        /// <summary>
        /// The number of backlinks from the referring IP address with particular domain name.
        /// </summary>
        [JsonProperty("backlinks", NullValueHandling = NullValueHandling.Ignore)]
        public long? Backlinks { get; set; }
    }
}
