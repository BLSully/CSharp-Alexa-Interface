**Summary**
===========
Collection of classes to make requests from and responses to Amazon's Alexa service easy. Uses JSON.NET for (de)serialization Request and Response bodies. It's pretty naive right now... no validation of constraints (e.g. response size limits in Cards, etc).

**Methods**
=======
**Request** *(from Alexa)*

    GetSessionAttribute(string key);

**Response** *(to Alexa)*

Following methods are chainable:

    SetOutputSpeech(string speech, OutputSpeechType type);
    
    SetCard(string title, string content, CardType type);
    
    SetReprompt(string speech, OutputSpeechType type);
    
    SetShouldEndSession(bool shouldEndSession);
    
    AddSessionAttribute(string key, object attr);


**Example**
===========
  public ResponseBody AlexaEndpoint([FromBody]RequestBody body) {
    ResponseBody resp = new ResponseBody();
    
    switch(request.Request.Type) {
      case Request.RequestType.LaunchRequest:
        //todo: welcome message here
        break;
      case Request.RequestType.IntentRequest:
        IntentRequest intent = (IntentRequest)request.Request
        switch(intent.Intent.Name) {
          case "HelloWorldIntent":
            resp
                    .SetOutputSpeech("You invoked Hello World.", OutputSpeechType.PlainText)
                    .SetReprompt("Say another command.", OutputSpeechType.PlainText);
            break;
        }
        break;
      case Request.RequestType.SessionEndedRequest:
        break;
    }
  }