using AlexaInterface.RequestParameters;
using Newtonsoft.Json;

namespace AlexaInterface {
  public class RequestBody {
    [JsonProperty("version")]
    public string Version { get; set; }

    [JsonProperty("session")]
    public Session Session { get; set; }

    [JsonProperty("request")]
    public IRequest Request { get; set; }

    public object GetSessionAttribute(string key) {
      if (this.Session == null || this.Session.Attributes == null || !this.Session.Attributes.ContainsKey(key))
        return null;

      return this.Session.Attributes[key];
    }
  }
}
