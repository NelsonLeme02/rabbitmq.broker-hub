using System;
using System.Text.Json.Serialization;

namespace rabbitmq.broker_hub.shared.Contracts;

public class PaymentsMessage
{
    [JsonPropertyName("sourceSystem")]
    public string SourceSystem { get; set; }

    [JsonPropertyName("eventId")]
    public string EventId { get; set; }

    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }

    [JsonPropertyName("settlementForm")]
    public int SettlementForm { get; set; }

    [JsonPropertyName("elapsedTime")]
    public long ElapsedTime { get; set; }

    [JsonPropertyName("scheduled")]
    public bool Scheduled { get; set; }

    [JsonPropertyName("suspectedFraud")]
    public bool SuspectedFraud { get; set; }

    [JsonPropertyName("antiFraud")]
    public bool? AntiFraud { get; set; }

    [JsonPropertyName("rejectedForTimeout")]
    public bool RejectedForTimeout { get; set; }

    [JsonPropertyName("rejected")]
    public bool Rejected { get; set; }

    [JsonPropertyName("reasonRejection")]
    public string ReasonRejection { get; set; }

    [JsonPropertyName("initiationProcedure")]
    public string InitiationProcedure { get; set; }

    [JsonPropertyName("initiationMechanism")]
    public string InitiationMechanism { get; set; }

    [JsonPropertyName("payerTaxIdType")]
    public string PayerTaxIdType { get; set; }

    [JsonPropertyName("receiverTaxIdType")]
    public string ReceiverTaxIdType { get; set; }

    [JsonPropertyName("initiationChannel")]
    public string InitiationChannel { get; set; }

    [JsonPropertyName("paymentPurpose")]
    public string PaymentPurpose { get; set; }

    [JsonPropertyName("cashAmount")]
    public decimal CashAmount { get; set; }
}