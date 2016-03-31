using AlexaInterface.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace AlexaInterface.JsonConverters {
  public class IRequestConverter : JsonCreationConverter<IRequest> {
    protected override IRequest Create(Type objectType, JObject jsonObject) {
      var requestType = (Request.RequestType)Enum.Parse(typeof(Request.RequestType), jsonObject.Value<string>("type"), true);

      switch (requestType) {
        case Request.RequestType.IntentRequest:
          return new IntentRequest();

        case Request.RequestType.LaunchRequest:
          return new LaunchRequest();

        case Request.RequestType.SessionEndedRequest:
          return new SessionEndedRequest();

        default:
          throw new Newtonsoft.Json.JsonSerializationException("Failed to detect type of IRequest");
      }
    }
  }
}
