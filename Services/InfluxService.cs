using InfluxDB.Client;
using Microsoft.Extensions.Options;
using Simplz.Monitoring.Options;

namespace Simplz.Monitoring.Services
{
    public class InfluxService
    {
        private readonly InfluxOptions _options;
        public InfluxService(IOptionsSnapshot<InfluxOptions> options)
        {
            _options = options.Value;
        }
        public async Task SendMessage()
        {
            using var client = InfluxDBClientFactory.Create(_options.Url, _options.Token);
            client.GetWriteApiAsync();

        }
    }
}
