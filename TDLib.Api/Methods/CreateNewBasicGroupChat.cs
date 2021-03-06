using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class CreateNewBasicGroupChat : Method<Chat>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "createNewBasicGroupChat";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("user_ids")]
        public int[] UserIds { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("title")]
        public string Title { get; set; }

    }

}
