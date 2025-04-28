using System;
using System.Text.Json.Serialization;

namespace rpnet.broker_matera_hub.shared.Contracts;

public class InconsistentMessage
{
    [JsonPropertyName("originalQueue")]
    public string OriginalQueue { get; set; }

    [JsonPropertyName("inconsistencies")]
    public Inconsistency[] Inconsistencies { get; set; }
}

public class Inconsistency
{
    [JsonPropertyName("eventId")]
    public string EventId { get; set; }

    [JsonPropertyName("inconsistent")]
    public string InconsistentDetail { get; set; }

    [JsonPropertyName("objectString")]
    public string ObjectStringDetail { get; set; }
}