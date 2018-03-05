using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Proxy : Structure
    {

        public partial class proxySocks5 : Proxy
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "proxySocks5";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("server")]
                public string server_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("port")]
                public int? port_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("username")]
                public string username_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("password")]
                public string password_;

        }

    }

}