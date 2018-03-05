using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class RecoveryEmailAddress : Structure
    {

        public partial class recoveryEmailAddress : RecoveryEmailAddress
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "recoveryEmailAddress";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("recovery_email_address")]
                public string recovery_email_address_;

        }

    }

}