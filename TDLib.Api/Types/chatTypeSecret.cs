using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatType : Structure
    {

        public class ChatTypeSecret : ChatType
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatTypeSecret";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("secret_chat_id")]
                public int SecretChatId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int UserId { get; set; }

        }

    }

}
