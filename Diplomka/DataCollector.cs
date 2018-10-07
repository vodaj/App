namespace Diplomka
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Web;

    public class DataCollector
    {
        public DataCollector()
        {
            string result = this.CallApi();
        }

        private string CallApi()
        {
            HttpClient client = new HttpClient();

            throw new NotImplementedException();
        }
    }
}