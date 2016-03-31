using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using AlexaInterface;
using AlexaInterface.RequestParameters;
using System.Collections.Generic;

namespace AlexaInterfaceTest {
  [TestClass]
  public class UnitTest1 {
    public UnitTest1() {
      JsonConvert.DefaultSettings = () => new JsonSerializerSettings {
        Converters = new List<JsonConverter> { new AlexaInterface.JsonConverters.IRequestConverter() }
      };
    }

    [TestMethod]
    public void TestLaunchRequestType() {
      string alexaRequest = @"{
        ""version"": ""1.0"",
        ""session"": {
          ""new"": true,
          ""sessionId"": ""amzn1.echo-api.session.0000000-0000-0000-0000-00000000000"",
          ""application"": {
            ""applicationId"": ""amzn1.echo-sdk-ams.app.000000-d0ed-0000-ad00-000000d00ebe""
          },
          ""attributes"": { },
          ""user"": {
            ""userId"": ""amzn1.account.AM3B00000000000000000000000""
          }
        },
        ""request"": {
          ""type"": ""LaunchRequest"",
          ""requestId"": ""amzn1.echo-api.request.0000000-0000-0000-0000-00000000000"",
          ""timestamp"": ""2015-05-13T12:34:56Z""
        }
      }";

      var request = JsonConvert.DeserializeObject<RequestBody>(alexaRequest);
      Assert.IsInstanceOfType(request.Request, typeof(LaunchRequest));
    }

    [TestMethod]
    public void TestHelloResponse() {
      //DO NOT CHANGE INDENT HERE. doing a string comparison includes whitespace
      var output = @"{
  ""version"": ""1.0"",
  ""sessionAttributes"": {},
  ""response"": {
    ""outputSpeech"": {
      ""type"": ""PlainText"",
      ""text"": ""Hello World!"",
      ""ssml"": null
    },
    ""card"": null,
    ""reprompt"": null,
    ""shouldEndSession"": false
  }
}";
      var body = new ResponseBody();
      body.SetOutputSpeech("Hello World!", AlexaInterface.ResponseParameters.OutputSpeechType.PlainText);
      var json = JsonConvert.SerializeObject(body, Formatting.Indented);
      Assert.AreEqual(output, json);
    }

    [TestMethod]
    public void TestHelloResponseWithReprompt() {
      //DO NOT CHANGE INDENT HERE. doing a string comparison includes whitespace
      var output = @"{
  ""version"": ""1.0"",
  ""sessionAttributes"": {},
  ""response"": {
    ""outputSpeech"": {
      ""type"": ""PlainText"",
      ""text"": ""Hello World!"",
      ""ssml"": null
    },
    ""card"": null,
    ""reprompt"": {
      ""outputSpeech"": {
        ""type"": ""PlainText"",
        ""text"": ""Tell me what to do"",
        ""ssml"": null
      }
    },
    ""shouldEndSession"": false
  }
}";
      var body = new ResponseBody();
      body
        .SetOutputSpeech("Hello World!", AlexaInterface.ResponseParameters.OutputSpeechType.PlainText)
        .SetReprompt("Tell me what to do", AlexaInterface.ResponseParameters.OutputSpeechType.PlainText);
      var json = JsonConvert.SerializeObject(body, Formatting.Indented);
      Assert.AreEqual(output, json);
    }

    [TestMethod]
    public void TestHelloResponseWithSimpleCard() {
      //DO NOT CHANGE INDENT HERE. doing a string comparison includes whitespace
      var output = @"{
  ""version"": ""1.0"",
  ""sessionAttributes"": {},
  ""response"": {
    ""outputSpeech"": {
      ""type"": ""PlainText"",
      ""text"": ""Hello World!"",
      ""ssml"": null
    },
    ""card"": {
      ""type"": ""Simple"",
      ""title"": ""Welcome"",
      ""content"": ""Welcome to Alexa Interface"",
      ""text"": null,
      ""image"": null
    },
    ""reprompt"": null,
    ""shouldEndSession"": false
  }
}";
      var body = new ResponseBody();
      body
        .SetOutputSpeech("Hello World!", AlexaInterface.ResponseParameters.OutputSpeechType.PlainText)
        .SetCard("Welcome", "Welcome to Alexa Interface", AlexaInterface.ResponseParameters.CardType.Simple);
      var json = JsonConvert.SerializeObject(body, Formatting.Indented);
      Assert.AreEqual(output, json);
    }
  }
}
