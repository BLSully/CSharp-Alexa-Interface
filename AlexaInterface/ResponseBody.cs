using AlexaInterface.ResponseParameters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaInterface {
  public class ResponseBody {
    public ResponseBody() {
      Response = new ResponseParameters.Response();
      SessionAttributes = new Dictionary<string, object>();
    }

    [JsonProperty("version")]
    public string Version { get { return Alexa.Version; } }

    [JsonProperty("sessionAttributes")]
    public Dictionary<string, object> SessionAttributes { get; private set; }

    [JsonProperty("response")]
    public Response Response { get; set; }

    public ResponseBody SetOutputSpeech(string speech, OutputSpeechType type) {
      this.Response.OutputSpeech = new OutputSpeech(speech, type);
      return this;
    }

    public ResponseBody SetCard(string title, string content, CardType type) {
      this.Response.Card = new Card(title, content, type);

      return this;
    }

    public ResponseBody SetReprompt(string speech, OutputSpeechType type) {
      this.Response.Reprompt = new Reprompt();
      this.Response.Reprompt.OutputSpeech = new OutputSpeech(speech, type);

      return this;
    }

    public ResponseBody SetShouldEndSession(bool shouldEndSession) {
      this.Response.ShouldEndSession = shouldEndSession;

      return this;
    }

    public ResponseBody AddSessionAttribute(string key, object attr) {
      this.SessionAttributes.Add(key, attr);

      return this;
    }
  }
}
