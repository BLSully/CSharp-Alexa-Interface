using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaInterface.RequestParameters {
  public static class Request {
    public enum RequestType {
      LaunchRequest,
      IntentRequest,
      SessionEndedRequest
    }

    public enum SessionEndedReason {
      USER_INITIATED,
      ERROR,
      EXCEEDED_MAX_REPROMPTS
    }
  }

  public interface IRequest {
    Request.RequestType Type { get; set; }
    string RequestId { get; set; }
    DateTime Timestamp { get; set; }
  }
}
