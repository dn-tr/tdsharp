using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class checkAuthenticationPassword : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "checkAuthenticationPassword";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("password")]
                public string password_;

        }

    }

}