using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Live_Currency_Exchange
{
    class API
    {

        private string url;
        private WebClient client;

        public API(string url)
        {
            this.url = url;
            this.client = new WebClient();
        }

        public string SendAndGetResponse()
        {
            return client.DownloadString(url);
        }

    }
}
