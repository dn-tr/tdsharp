using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class MessageContent : Structure
    {

        public class MessageChatJoinByLink : MessageContent
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageChatJoinByLink";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
