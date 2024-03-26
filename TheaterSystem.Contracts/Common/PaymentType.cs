using System.Text.Json.Serialization;

namespace TheaterSystem.Contracts.Common;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PaymentType
{
    Money,
    CreditCard,
    DebitCard
}