using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class KeyboardButtonType : Structure
    {

        public partial class keyboardButtonTypeRequestPhoneNumber : KeyboardButtonType
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "keyboardButtonTypeRequestPhoneNumber";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}