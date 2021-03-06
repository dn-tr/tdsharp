using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class ChangePhoneNumber : Method<AuthenticationCodeInfo>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "changePhoneNumber";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("allow_flash_call")]
        public bool AllowFlashCall { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("is_current_phone_number")]
        public bool IsCurrentPhoneNumber { get; set; }

    }

}
