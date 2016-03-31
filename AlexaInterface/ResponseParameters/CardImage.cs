using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaInterface.ResponseParameters {
  public class CardImage {
    [JsonProperty("smallImageUrl")]
    public string Small { get; set; }

    [JsonProperty("largeImageUrl")]
    public string Large { get; set; }
  }
}
