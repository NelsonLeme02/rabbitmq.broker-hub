using System;
using System.Text.Json.Serialization;

namespace rabbitmq.broker_hub.shared.Contracts;

public class DictMessage
{
    [JsonPropertyName("sourceSystem")]
    public string? SourceSystem { get; set; }

    [JsonPropertyName("eventId")]
    public string? EventId { get; set; }

    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("elapsedTime")]
    public TimeSpan ElapsedTime { get; set; }

    [JsonPropertyName("elapsedTimeType")]
    public ElapsedTimeType ElapsedTimeType { get; set; }
}

public enum ElapsedTimeType
{
    ConsultaDictPagante = 1,
    EnvioCodigoCadastroChave = 2,
    ExperienciaCadastroChave = 3,
    ExperienciaExclusaoChave = 4,
    TempoEntreRecebimentoDictENotificacaoDoador = 5,
    TempoEntreConfirmacaoCancelamentoEEnvioDict = 6,
    TempoEntreReclamacaoEAberturaMed = 7
}