using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class SetBotUpdatesStatus : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "setBotUpdatesStatus";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("pending_update_count")]
        public int PendingUpdateCount { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

    }

}
