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
            _apiToken = apiToken;
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
