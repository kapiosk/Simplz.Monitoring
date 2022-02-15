namespace Simplz.Monitoring.Models.Kibana
{
    public record Alert
    {
        public string AlertActionGroup { get; init; } = string.Empty;
        public string AlertActionGroupName { get; init; } = string.Empty;
        public string AlertId { get; init; } = string.Empty;
        public string AlertInstanceId { get; init; } = string.Empty;
        public string AlertName { get; init; } = string.Empty;
        public string Date { get; init; } = string.Empty;
        public string SpaceId { get; init; } = string.Empty;
        public string Tags { get; init; } = string.Empty;
    }
}
