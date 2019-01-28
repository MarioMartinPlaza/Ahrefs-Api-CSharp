using System;
using System.Collections.Generic;
using System.Text;

namespace AhrefsClient
{
    internal class AhrefsDomain
    {
        internal static string GetDomain(AhrefsEndpoints ahrefsEndpoints)
        {
            switch (ahrefsEndpoints)
            {
                case AhrefsEndpoints.ApiV2:
                    return "apiv2.ahrefs.com";               
                default:
                    return "apiv2.ahrefs.com";
            }
        }
    }
}
