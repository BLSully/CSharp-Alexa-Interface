namespace AlexaInterface {
  internal class Alexa {
    internal static string Version
    {
      get
      {
        return System.Configuration.ConfigurationManager.AppSettings["AlexaInterface.Version"] ?? "1.0";
      }
    }
  }
}
