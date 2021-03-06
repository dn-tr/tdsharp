using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public class UpdateNewChosenInlineResult : Update
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateNewChosenInlineResult";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sender_user_id")]
                public int SenderUserId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_location")]
                public Location UserLocation { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("query")]
                public string Query { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("result_id")]
                public string ResultId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("inline_message_id")]
                public string InlineMessageId { get; set; }

        }

    }

}
