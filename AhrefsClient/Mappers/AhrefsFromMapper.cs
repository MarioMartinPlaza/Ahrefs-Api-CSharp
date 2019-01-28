using AhrefsClient.Enums;
using AhrefsClient.Models.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AhrefsClient.Mappers
{
    public static class AhrefsFromMapper
    {
        public static Type GetClassType(AhrefsFrom from)
        {
            Type returnClass = null;
            switch (from)
            {
                case AhrefsFrom.ahrefs_rank:
                    returnClass = typeof(AhrefsRank);
                    break;
                case AhrefsFrom.anchors:
                    returnClass = typeof(AhrefsAnchors);
                    break;
                case AhrefsFrom.anchors_refdomains:
                    returnClass = typeof(AhrefsRefDomains);
                    break;
                case AhrefsFrom.backlinks:
                    returnClass = typeof(AhrefsBacklinks);
                    break;
                case AhrefsFrom.backlinks_new_lost:
                    returnClass = typeof(AhrefsBacklinksNewLost);
                    break;
                case AhrefsFrom.backlinks_new_lost_counters:
                    returnClass = typeof(AhrefsBacklinksNewLostCounters);
                    break;
                case AhrefsFrom.backlinks_one_per_domain:
                    returnClass = typeof(AhrefsBacklinksOnePerDomain);
                    break;
                case AhrefsFrom.broken_backlinks:
                    returnClass = typeof(AhrefsBacklinks);
                    break;
                case AhrefsFrom.broken_links:
                    returnClass = typeof(AhrefsBrokenLinks);
                    break;
                case AhrefsFrom.domain_rating:
                    returnClass = typeof(AhrefsDomainRating);
                    break;
                case AhrefsFrom.linked_anchors:
                    returnClass = typeof(AhrefsLinkedAnchors);
                    break;
                case AhrefsFrom.linked_domains:
                    returnClass = typeof(AhrefsLinkedDomains);
                    break;
                case AhrefsFrom.linked_domains_by_type:
                    returnClass = typeof(AhrefsLinkedDomainsByType);
                    break;
                case AhrefsFrom.metrics:
                    returnClass = typeof(AhrefsMetrics);
                    break;
                case AhrefsFrom.metrics_extended:
                    returnClass = typeof(AhrefsMetricsExtended);
                    break;
                case AhrefsFrom.pages:
                    returnClass = typeof(AhrefsPages);
                    break;
                case AhrefsFrom.pages_extended:
                    returnClass = typeof(AhrefsPagesExtended);
                    break;
                case AhrefsFrom.pages_info:
                    returnClass = typeof(AhrefsPagesInfo);
                    break;
                case AhrefsFrom.refdomains:
                    returnClass = typeof(AhrefsRefDomains);
                    break;
                case AhrefsFrom.refdomains_by_type:
                    returnClass = typeof(AhrefsRefDomainsByType);
                    break;
                case AhrefsFrom.refdomains_new_lost:
                    returnClass = typeof(AhrefsRefDomainsNewLost);
                    break;
                case AhrefsFrom.refdomains_new_lost_counters:
                    returnClass = typeof(AhrefsRefDomainsNewLostCounters);
                    break;
                case AhrefsFrom.refips:
                    returnClass = typeof(AhrefsRefips);
                    break;
                case AhrefsFrom.subscription_info:
                    returnClass = typeof(AhrefsSubscriptionInfo);
                    break;
            }
            return returnClass;
        }
    }
}
