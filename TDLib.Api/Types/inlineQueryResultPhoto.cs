using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InlineQueryResult : Structure
    {

        public class InlineQueryResultPhoto : InlineQueryResult
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inlineQueryResultPhoto";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo")]
                public Photo Photo { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("description")]
                public string Description { get; set; }

        }

    }

}
