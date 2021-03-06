using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class DeleteMessages : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "deleteMessages";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("message_ids")]
        public long[] MessageIds { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("revoke")]
        public bool Revoke { get; set; }

    }

}
