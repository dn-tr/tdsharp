using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class AuthenticationCodeType : Structure
    {

        public class AuthenticationCodeTypeSms : AuthenticationCodeType
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "authenticationCodeTypeSms";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("length")]
                public int Length { get; set; }

        }

    }

}
