using Newtonsoft.Json;

namespace AlexaInterface.ResponseParameters {
  public class Reprompt {
    [JsonProperty("outputSpeech")]
    public OutputSpeech OutputSpeech { get; set; }
  }
}