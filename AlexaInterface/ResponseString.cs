using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace AlexaInterface {
  public class ResponseString {
    internal PromptBuilder primaryBuilder = new PromptBuilder();

    public void AppendString(string content) {
      primaryBuilder.AppendSsmlMarkup(content);
    }

    public string GetXML() {
      return primaryBuilder.ToXml();
    }
  }
}
