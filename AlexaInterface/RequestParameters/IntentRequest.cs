using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AlexaInterface.RequestParameters {
  public class IntentRequest : IRequest {
    [JsonProperty("type")]
    [JsonConverter(typeof(StringEnumConverter))]
    public Request.RequestType Type { get; set; }

    [JsonProperty("requestId")]
    public string RequestId { get; set; }

    [JsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonProperty("intent")]
    public Intent Intent { get; set; }
  }
}
