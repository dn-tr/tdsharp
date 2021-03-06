using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class Invoice : Structure
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "invoice";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("price_parts")]
        public LabeledPricePart[] PriceParts { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("is_test")]
        public bool IsTest { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("need_name")]
        public bool NeedName { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("need_phone_number")]
        public bool NeedPhoneNumber { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("need_email_address")]
        public bool NeedEmailAddress { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("need_shipping_address")]
        public bool NeedShippingAddress { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("send_phone_number_to_provider")]
        public bool SendPhoneNumberToProvider { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("send_email_address_to_provider")]
        public bool SendEmailAddressToProvider { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("is_flexible")]
        public bool IsFlexible { get; set; }

    }

}
