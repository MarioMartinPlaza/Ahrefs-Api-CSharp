using System;
using System.Collections.Generic;
using System.Text;

namespace AhrefsClient.Enums
{
    public enum AhrefsFrom
    {
        /// <summary>
        /// Contains the URLs and the rankings.
        /// </summary>
        ahrefs_rank,
        /// <summary>
        /// Contains the anchor text and the # of backlinks, referring pages and referring domains that has it.
        /// </summary>
        anchors,

        /// <summary>
        /// Contains the # of anchors and backlinks with that anchor, per domain.
        /// </summary>
        anchors_refdomains,

        /// <summary>
        /// Contains the backlinks and details of the referring pages, such as anchor and page title.
        /// </summary>
        backlinks,

        /// <summary>
        /// Contains the new or lost backlinks and details of the referring pages.
        /// </summary>
        backlinks_new_lost,

        /// <summary>
        /// Contains new and lost backlink totals.
        /// </summary>
        backlinks_new_lost_counters,

        /// <summary>
        /// Contains the backlinks and details of the referring pages, such as anchor and page title.
        /// </summary>
        backlinks_one_per_domain,

        /// <summary>
        /// Contains the broken backlinks and details of the referring pages, such as anchor and page title.
        /// </summary>
        broken_backlinks,

        /// <summary>
        /// Contains the broken links and details of the referring pages, such as anchor and page title.
        /// </summary>
        broken_links,

        /// <summary>
        /// Contains the Domain Rating.
        /// </summary>
        domain_rating,

        /// <summary>
        /// Contains the anchor text and # of outgoing external and internal links that have it.
        /// </summary>
        linked_anchors,

        /// <summary>
        /// Contains the domains that the target links to.
        /// </summary>
        linked_domains,

        /// <summary>
        /// Contains the domains that the target links to.
        /// </summary>
        linked_domains_by_type,

        /// <summary>
        /// Contains metrics about the target, such as total # of backlinks, referring pages, etc.
        /// </summary>
        metrics,

        /// <summary>
        /// Contains additional metrics about the target, such as total # of referring domains, referring class C networks and referring IP addresses.
        /// </summary>
        metrics_extended,

        /// <summary>
        /// Contains the crawled pages.
        /// </summary>
        pages,

        /// <summary>
        /// Contains additional info about the crawled pages, such as total # of backlinks, dofollow/nonfollow links, etc.
        /// </summary>
        pages_extended,

        /// <summary>
        /// Contains additional info about the crawled pages, such as IP address, canonical URL, social metrics etc.
        /// </summary>
        pages_info,

        /// <summary>
        /// Contains the referring domains that contain backlinks to the target.
        /// </summary>
        refdomains,

        /// <summary>
        /// Contains the referring domains that contain backlinks to the target.
        /// </summary>
        refdomains_by_type,

        /// <summary>
        /// Contains the new or lost referring domains and their details.
        /// </summary>
        refdomains_new_lost,

        /// <summary>
        /// Contains new and lost domains totals.
        /// </summary>
        refdomains_new_lost_counters,

        /// <summary>
        /// Returns the referring IP addresses linking to the target.
        /// </summary>
        refips,

        /// <summary>
        /// Contains user subscription information.
        /// </summary>
        subscription_info

    }
}
