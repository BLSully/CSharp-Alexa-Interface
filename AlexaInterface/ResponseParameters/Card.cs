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
    public Card() { }

    public Card(string title, string content, CardType type) {
      this.Type = type;

      switch (this.Type) {
        case CardType.Simple:
          this.Title = title;
          this.Content = content;
          break;
        case CardType.Standard:
          this.Title = title;
          this.Text = content;
          break;
      }
    }

    public Card(string title, string content, string image) : this(title, content, CardType.Standard) {
      this.Image = new CardImage {
        Small = image,
        Large = image
      };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="title"></param>
    /// <param name="content"></param>
    /// <param name="smImage">recommended 720x480</param>
    /// <param name="lgImage">recommended 1200x800</param>
    public Card(string title, string content, string smImage, string lgImage) : this(title, content, CardType.Standard) {
      this.Image = new CardImage {
        Small = smImage,
        Large = lgImage
      };
    }

    public static Card CreateAccountLink() {
      return new Card(null, null, CardType.LinkAccount);
    }

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
    public CardImage Image { get; set; }
  }
}