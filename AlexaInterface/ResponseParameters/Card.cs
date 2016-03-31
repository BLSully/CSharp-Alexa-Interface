using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AlexaInterface.ResponseParameters {
  //https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/providing-home-cards-for-the-amazon-alexa-app

  public enum CardType {
    Simple,
    Standard,
    LinkAccount
  }

  public class Card {
    [JsonProperty("type")]
    [JsonConverter(typeof(StringEnumConverter))]
    public CardType Type { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("content")]
    public string Content { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("image")]
    public object Image { get; set; }
  }
}