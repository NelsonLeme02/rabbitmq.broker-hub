using System;
using System.Text.Json.Serialization;

namespace rabbitmq.broker_hub.shared.Contracts;

public class ReturnsMessage
{
    [JsonPropertyName("sourceSystem")]
    public string SourceSystem { get; set; }

    [JsonPropertyName("eventId")]
    public string EventId { get; set; }

    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }

    [JsonPropertyName("elapsedTime")]
    public TimeSpan ElapsedTime { get; set; }

    [JsonPropertyName("originalEventId")]
    public string OriginalEventId { get; set; }

    [JsonPropertyName("settlementForm")]
    public int SettlementForm { get; set; }

    [JsonPropertyName("reasonCode")]
    public string ReasonCode { get; set; }
}
