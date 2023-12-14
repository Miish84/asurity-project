using System.Net;

namespace ContactApi.Dtos
{
    public class AppMessage
    {
        public HttpStatusCode Code { get; set; }
        public Type ExceptionType { get; set; }
        public string CustomMessage { get; set; }
        public object Payload { get; set; }

        public AppMessage(HttpStatusCode code = HttpStatusCode.OK, string customMessage = "ok", Type exceptionType = null, object payload = null) {
            this.Code = code;
            this.ExceptionType = exceptionType;
            this.CustomMessage = customMessage;
            this.Payload = payload;
        }
    }
}
