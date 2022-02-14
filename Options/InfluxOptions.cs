namespace Simplz.Monitoring.Options
{
    public record InfluxOptions
    {
        public string Url { get; init; }=string.Empty;
        public string Token { get; init; } = string.Empty;
        public string Org { get; init; } = string.Empty;
    }
}
