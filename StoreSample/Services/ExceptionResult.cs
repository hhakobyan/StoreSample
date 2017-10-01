namespace StoreSample.Services
{
    using System;

    using Newtonsoft.Json;

    public class ExceptionResult
    {
        public string Message { get; set; }

        public string ExceptionMessage { get; set; }

        public string ExceptionType { get; set; }

        public string StackTrace { get; set; }

        public ExceptionResult InnerException { get; set; }

        public Exception ToException()
        {
            return new ApplicationException(this.ExceptionMessage ?? this.Message, new Exception(JsonConvert.SerializeObject(this.InnerException, Formatting.Indented)));
        }
    }
}