using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class setBio : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "setBio";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("bio")]
                public string bio_;

        }

    }

}