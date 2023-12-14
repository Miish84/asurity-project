using System.Net;

namespace ContactApi.Dtos
{
    public class AppMessage<T> where T : class
    {
        private readonly HttpStatusCode code;
        private readonly Exception exception;
        private readonly string customMessage;
        private readonly object payload;

        public AppMessage(HttpStatusCode code = HttpStatusCode.OK, string customMessage = "ok", Exception exception = null, T payload = null) {
            this.code = code;
            this.exception = exception;
            this.customMessage = customMessage;
            this.payload = payload;
        }
    }
}
