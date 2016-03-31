using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaInterface.ResponseParameters {
  public class Response {
    public Response() {
      //OutputSpeech = new OutputSpeech();
      ShouldEndSession = false;
    }

    [JsonProperty("outputSpeech")]
    public OutputSpeech OutputSpeech { get; set; }

    [JsonProperty("card")]
    public Card Card { get; set; }

    [JsonProperty("reprompt")]
    public Reprompt Reprompt { get; set; }

    [JsonProperty("shouldEndSession")]
    public bool ShouldEndSession { get; set; }
  }
}
