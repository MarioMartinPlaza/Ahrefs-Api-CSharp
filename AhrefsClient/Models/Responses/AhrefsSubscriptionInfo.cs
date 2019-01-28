namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsSubscriptionInfo
    {
        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public Info Info { get; set; }
    }

    public partial class Info
    {
        /// <summary>
        /// Number of rows available for making API requests.
        /// </summary>
        [JsonProperty("rows_left", NullValueHandling = NullValueHandling.Ignore)]
        public long? RowsLeft { get; set; }

        /// <summary>
        /// Total number of rows available for the subscription plan.
        /// </summary>
        [JsonProperty("rows_limit", NullValueHandling = NullValueHandling.Ignore)]
        public long? RowsLimit { get; set; }

        /// <summary>
        /// Name of the API subscription plan.
        /// </summary>
        [JsonProperty("subscription", NullValueHandling = NullValueHandling.Ignore)]
        public string Subscription { get; set; }
    }
}
