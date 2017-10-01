namespace StoreSample.Services
{
    using System;
    using System.Net.Http;
    using System.Text;

    using Newtonsoft.Json;

    internal static class HttpResponseExtensions
    {
        public static HttpResponseMessage HandleError(this HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                return response;
            }

            // var exception = response.Content.ReadAsAsync<ExceptionResult>().Result;
            var bytes = response.Content.ReadAsByteArrayAsync().Result;
            var strResult = Encoding.UTF8.GetString(bytes);
            var exception = JsonConvert.DeserializeObject<ExceptionResult>(strResult)
                            ?? new ExceptionResult { ExceptionMessage = response.ReasonPhrase };
            throw new Exception(exception.ExceptionMessage, exception.ToException());
        }
    }
}
