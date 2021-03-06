using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class AuthorizationState : Structure
    {

        public class AuthorizationStateWaitCode : AuthorizationState
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "authorizationStateWaitCode";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_registered")]
                public bool IsRegistered { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("code_info")]
                public AuthenticationCodeInfo CodeInfo { get; set; }

        }

    }

}
