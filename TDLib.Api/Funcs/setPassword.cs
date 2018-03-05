using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class setPassword : Method<PasswordState>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "setPassword";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("old_password")]
                public string old_password_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_password")]
                public string new_password_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_hint")]
                public string new_hint_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("set_recovery_email_address")]
                public bool? set_recovery_email_address_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_recovery_email_address")]
                public string new_recovery_email_address_;

        }

    }

}