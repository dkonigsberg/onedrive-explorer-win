using System;
using System.Collections.Generic;

namespace OneDrive
{
    public class ODServerException : ODException
    {
        public ODServerException(string message, Exception innerException = null)
            : base(message, innerException)
        {
        }

        public int HttpStatusCode { get; internal set; }
        public string HttpStatusMessage { get; internal set; }
        public IReadOnlyDictionary<string, string> HttpHeaders { get; internal set; }
        public ODError ServiceError { get; internal set; }
        public HttpResponseType ResponseType { get { return HttpStatusCode.ToHttpResponseType(); } }
    }
}
