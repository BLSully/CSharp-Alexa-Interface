using Newtonsoft.Json;

namespace AlexaInterface.RequestParameters {
  public class Application {
    [JsonProperty("applicationId")]
    public string ApplicationId { get; set; }
  }
}
