namespace AhrefsClient.Models.Responses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AhrefsLinkedAnchors
    {
        [JsonProperty("anchors", NullValueHandling = NullValueHandling.Ignore)]
        public List<LinkedAnchor> Anchors { get; set; }
    }

    public partial class LinkedAnchor : Anchor
    {
        /// <summary>
        /// Number of internal outgoing links found that are using the anchor text.
        /// </summary>
        [JsonProperty("links_internal", NullValueHandling = NullValueHandling.Ignore)]
        public long? LinksInternal { get; set; }

        /// <summary>
        /// Number of external outgoing links found that are using the anchor text.
        /// </summary>
        [JsonProperty("links_external", NullValueHandling = NullValueHandling.Ignore)]
        public long? LinksExternal { get; set; }
    }
}
