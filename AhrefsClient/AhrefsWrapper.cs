using AhrefsClient.Enums;
using AhrefsClient.Mappers;
using AhrefsClient.Models;
using AhrefsClient.Models.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace AhrefsClient
{
    public class AhrefsWrapper : IAhrefsWrapper
    {
        private IAhrefsAuthentication _ahrefsAuthentication;
        private AhrefsEndpoints _ahrefsEndPoints;
        public AhrefsWrapper(IAhrefsAuthentication ahrefsAuthentication, AhrefsEndpoints ahrefsEndPoints = AhrefsEndpoints.ApiV2)
        {
            this._ahrefsAuthentication = ahrefsAuthentication;
            this._ahrefsEndPoints = ahrefsEndPoints;
        }


        public object MakeRequest(AhrefsQuery ahrefsQuery)
        {
            ahrefsQuery.SetToken(_ahrefsAuthentication.GetToken());
            var builder = new UriBuilder(AhrefsDomain.GetDomain(_ahrefsEndPoints));
            builder.Query = ahrefsQuery.GetQueryString().ToString();

            var rawResponse = SendRequest(builder.ToString());
            return DeserializeObject(rawResponse, ahrefsQuery.From);
        }

        private string SendRequest(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            try
            {
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                        return reader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private object DeserializeObject(string ObjectToDeserialize, AhrefsFrom from)
        {
            var classType = AhrefsFromMapper.GetClassType(from);
            var deserializedObject = JsonConvert.DeserializeObject(ObjectToDeserialize, classType);
            return deserializedObject;
        }

        

    }
}
