using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class MessageContent : Structure
    {

        public class MessageChatSetTtl : MessageContent
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageChatSetTtl";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("ttl")]
                public int Ttl { get; set; }

        }

    }

}
