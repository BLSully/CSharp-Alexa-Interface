using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace AlexaInterface.ResponseParameters {
  public enum OutputSpeechType {
    PlainText,
    SSML
  }

  public class OutputSpeech {
    public OutputSpeech() { }

    public OutputSpeech(string text, OutputSpeechType type) {
      Type = type;
      SetText(text);
    }

    public void SetText(string text) {
      switch (this.Type) {
        case OutputSpeechType.PlainText:
          this.Text = text;
          break;
        case OutputSpeechType.SSML:
          this.SSML = text;
          break;
      }
    }

    [JsonProperty("type")]
    [JsonConverter(typeof(StringEnumConverter))]
    public OutputSpeechType Type { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("ssml")]
    public string SSML { get; set; }
  }
}
