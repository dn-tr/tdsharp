using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class SearchContacts : Method<Users>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "searchContacts";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("limit")]
        public int Limit { get; set; }

    }

}
