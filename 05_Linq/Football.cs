using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace _05_Linq
{
  public partial class Football
  {
    [JsonProperty("Date")]
    public string Date { get; set; }

    [JsonProperty("HomeTeam")]
    public string HomeTeam { get; set; }

    [JsonProperty("Awayteam")]
    public string Awayteam { get; set; }

    [JsonProperty("Htgoals")]
    public long Htgoals { get; set; }

    [JsonProperty("atgoals")]
    public long Atgoals { get; set; }

    [JsonProperty("home")]
    public string Home { get; set; }

    [JsonProperty("away")]
    public string Away { get; set; }

    [JsonProperty("stadium")]
    public string Stadium { get; set; }
  }

  public partial class Football
  {
    public static Football FromJson(string json) => JsonConvert.DeserializeObject<Football>(json, _05_Linq.Converter.Settings);
  }

  public static class Serialize
  {
    public static string ToJson(this Football self) => JsonConvert.SerializeObject(self,  _05_Linq.Converter.Settings);
  }

  internal static class Converter
  {
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
      MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
      DateParseHandling = DateParseHandling.None,
      Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
    };
  }

}