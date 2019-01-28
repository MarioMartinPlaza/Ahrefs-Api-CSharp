namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsRank
    {
        [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
        public List<RankPage> Pages { get; set; }
    }

    public partial class RankPage
    {
        /// <summary>
        /// Target of the request.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        /// <summary>
        /// URL Rating of the target.
        /// </summary>
        [JsonProperty("ahrefs_rank", NullValueHandling = NullValueHandling.Ignore)]
        public long? AhrefsRank { get; set; }
    }       
}
