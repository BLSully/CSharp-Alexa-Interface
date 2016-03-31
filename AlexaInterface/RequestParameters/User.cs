using Newtonsoft.Json;

namespace AlexaInterface.RequestParameters {
  public class User {
    [JsonProperty("userId")]
    public string UserId { get; set; }

    [JsonProperty("accessToken")]
    public string AccessToken { get; set; }
  }
}
