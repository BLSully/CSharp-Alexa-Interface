using Newtonsoft.Json;
using System.Collections.Generic;

namespace AlexaInterface.RequestParameters {
  public class Intent {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("slots")]
    public Dictionary<string, Slot> Slots { get; set; }
  }
}
