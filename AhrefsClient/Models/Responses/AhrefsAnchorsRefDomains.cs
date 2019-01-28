namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsAnchorsRefDomains
    {
        [JsonProperty("refdomains", NullValueHandling = NullValueHandling.Ignore)]
        public List<RefdomainAnchors> Refdomains { get; set; }
    }

    public partial class RefdomainAnchors : Refdomain
    {
        /// <summary>
        /// Number of different anchor texts that are used in backlinks to the target on the referring domain
        /// </summary>
        [JsonProperty("anchors", NullValueHandling = NullValueHandling.Ignore)]
        public long? Anchors { get; set; }      
    }    
}
