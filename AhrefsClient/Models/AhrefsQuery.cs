using AhrefsClient.Enums;
using AhrefsClient.Models.Responses;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace AhrefsClient.Models
{
    public class AhrefsQuery
    {
        private string resultQuery;
        private string Token { get; set; }
        public string Select { get; set; }
        public AhrefsFrom From { get; set; }
        public string Target { get; set; }
        public string Mode { get; set; }
        public string Where { get; set; }
        public string Having { get; set; }
        public string Order_by { get; set; }
        public int Limit { get; set; }
        public AhrefsOutputTypes? Output = AhrefsOutputTypes.json;

        public NameValueCollection GetQueryString()
        {

            var queryString = HttpUtility.ParseQueryString("data");            
            if (!string.IsNullOrEmpty(Select))
                queryString.Add("select", Select);
            else
                queryString.Add("select", "*");

            if (From != null)
                queryString.Add("from", From.ToString());
            if (!string.IsNullOrEmpty(Target))
                queryString.Add("target", Target);
            if (!string.IsNullOrEmpty(Mode))
                queryString.Add("mode", Mode);
            if (!string.IsNullOrEmpty(Where))
                queryString.Add("where", Where);
            if (!string.IsNullOrEmpty(Having))
                queryString.Add("having", Having);
            if (!string.IsNullOrEmpty(Order_by))
                queryString.Add("order_by", Order_by);
            if (Limit > 0)
                queryString.Add("limit", Limit.ToString());
            if (Output != null)
                queryString.Add("output", Output.ToString());
            if (!string.IsNullOrEmpty(Token))
                queryString.Add("token", Token);
            return queryString;
        }
        public void SetToken(string apiToken)
        {
            Token = apiToken;
        }
    }
}
