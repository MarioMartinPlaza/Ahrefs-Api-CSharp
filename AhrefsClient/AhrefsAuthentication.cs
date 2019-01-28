using System;
using System.Collections.Generic;
using System.Text;

namespace AhrefsClient
{
    public class AhrefsAuthentication : IAhrefsAuthentication
    {
        private string _apiToken;
        public AhrefsAuthentication(string apiToken)
        {
            _apiToken = "29a69e881487d7c81b5c2ddd3ac95ed6cd5c0f7e";
        }
        public string GetToken()
        {
            return _apiToken;
        }
        public string GetQueryString()
        {
            return $"?token={this._apiToken}";
        }
        public string AddToken(string url)
        {
            return $"{url}{GetQueryString()}";
        }
    }
}
