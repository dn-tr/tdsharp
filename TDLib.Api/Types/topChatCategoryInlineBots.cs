using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TopChatCategory : Structure
    {

        public partial class topChatCategoryInlineBots : TopChatCategory
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "topChatCategoryInlineBots";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}