using System.Text.Json.Serialization;

namespace rpnet.broker_matera_hub.rpnet.broker_matera_hub.shared.Contracts;
public class BlockMessage
{
    [JsonPropertyName("sourceSystem")]
    public string? SourceSystem { get; set; }

    [JsonPropertyName("blockId")]
    public string? BlockId { get; set; }

    [JsonPropertyName("paymentId")]
    public string? PaymentId { get; set; }

    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }

    [JsonPropertyName("blockTime")]
    public TimeSpan? BlockTime { get; set; }

    [JsonPropertyName("blockStatus")]
    public BlockStatusType BlockStatus { get; set; }
}

public enum BlockStatusType
{
    BloqueadoEmAnalise = 1,
    LiberadoPosAnalise = 2,
    MecanismoEspecialDevolucao = 3,
    DevolvidoAPedidoAntesAnalise = 4
}