using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BankTransactions.SerializationModels
{
    public partial class GeorgeTransaction
    {
        [JsonProperty("booking")]
        public DateTime BookingDate { get; set; }

        [JsonProperty("valuation")]
        public object Valuation { get; set; }

        [JsonProperty("partnerName")]
        public string PartnerName { get; set; }

        [JsonProperty("partnerAccount")]
        public PartnerAccount PartnerAccount { get; set; }

        [JsonProperty("amount")]
        public Amount Amount { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("categories")]
        public object Categories { get; set; }

        [JsonProperty("favorite")]
        public object Favorite { get; set; }

        [JsonProperty("constantSymbol")]
        public object ConstantSymbol { get; set; }

        [JsonProperty("variableSymbol")]
        public object VariableSymbol { get; set; }

        [JsonProperty("specificSymbol")]
        public object SpecificSymbol { get; set; }

        [JsonProperty("receiverReference")]
        public object ReceiverReference { get; set; }

        [JsonProperty("receiverAddress")]
        public object ReceiverAddress { get; set; }

        [JsonProperty("senderReference")]
        public object SenderReference { get; set; }

        [JsonProperty("senderAddress")]
        public object SenderAddress { get; set; }

        [JsonProperty("cardNumber")]
        public object CardNumber { get; set; }

        [JsonProperty("cardLocation")]
        public object CardLocation { get; set; }

        [JsonProperty("investmentInstrumentName")]
        public object InvestmentInstrumentName { get; set; }

        [JsonProperty("bookingTypeTranslation")]
        public object BookingTypeTranslation { get; set; }

        [JsonProperty("e2eReference")]
        public object E2EReference { get; set; }

        [JsonProperty("virtualCardNumber")]
        public object VirtualCardNumber { get; set; }

        [JsonProperty("virtualCardDeviceName")]
        public object VirtualCardDeviceName { get; set; }

        [JsonProperty("virtualCardMobilePaymentApplicationName")]
        public object VirtualCardMobilePaymentApplicationName { get; set; }
    }

    public partial class Amount
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("precision")]
        public long Precision { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public partial class PartnerAccount
    {
        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("bic")]
        public string Bic { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("prefix")]
        public object Prefix { get; set; }
    }

    public partial class GeorgeTransaction
    {
        public static List<GeorgeTransaction> FromJson(string json) => JsonConvert.DeserializeObject<List<GeorgeTransaction>>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<GeorgeTransaction> self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

