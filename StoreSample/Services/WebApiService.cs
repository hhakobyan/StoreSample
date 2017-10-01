using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace StoreSample.Services
{
    public abstract class WebApiService
    {
        private HttpClient client;

        public WebApiService(string controller)
        {
            this.client = new HttpClient
            {
                BaseAddress = new Uri($"{HttpContext.Current.Request.Url.Scheme}://{HttpContext.Current.Request.Url.Authority}/api/{controller}/")
            };

            // Add an Accept header for JSON format.
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public HttpClient Client => this.client;
    }
}