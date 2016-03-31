﻿using Newtonsoft.Json;

namespace AlexaInterface.RequestParameters {
  public class Slot {
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("value")]
    public string Value { get; set; }
  }
}
