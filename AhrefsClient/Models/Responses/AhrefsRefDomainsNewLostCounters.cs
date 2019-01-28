namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsRefDomainsNewLostCounters
    {
        [JsonProperty("counts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Count> Counts { get; set; }
    }
}
