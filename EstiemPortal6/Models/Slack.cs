using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EstiemPortal6.Models
{
    public class Slack
    {
        private readonly Uri _uri;
        private readonly Encoding _encoding = new UTF8Encoding();

        public Slack(string urlWithAccessToken)
        {
            _uri = new Uri(urlWithAccessToken);
        }

        public void PostMessage(string text, string username = null, string channel = null)
        {
            Payload payload = new Payload()
            {
                Channel = channel,
                Username = username,
                Text = text
            };

            PostMessage(payload);
        }
        //Post a message using a Payload object  
        public void PostMessage(Payload payload)
        {
            string payloadJson = JsonConvert.SerializeObject(payload);

            using (WebClient client = new WebClient())
            {
                NameValueCollection data = new NameValueCollection();
                data["payload"] = payloadJson;

                var response = client.UploadValues(_uri, "POST", data);

                //The response text is usually "ok"  
                string responseText = _encoding.GetString(response);
            }
        }

        public async Task<HttpResponseMessage> PostToSlack(string method, string parameters)
        {
            string url = "https://slack.com/api/" + method + parameters;
            //+ System.Configuration.ConfigurationManager.AppSettings["SlackToken"]
            //+ "&name=%23" + name + "&pretty=1";
            HttpClient client = new HttpClient();
            Task<HttpResponseMessage> PostToSlack = client.GetAsync(url);
            var a = await PostToSlack;
            return a;
        }
    }


    public class Payload
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class Slashcommand
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("response_type")]
        public string ResponseType { get; set; }
    }
}