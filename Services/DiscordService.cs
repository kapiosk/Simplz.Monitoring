using Microsoft.Extensions.Options;
using Simplz.Monitoring.Options;

namespace Simplz.Monitoring.Services
{
    public class DiscordService
    {
        private readonly DiscordOptions _options;
        public DiscordService(IOptionsSnapshot<DiscordOptions> options)
        {
            _options = options.Value;
        }

        public async Task SendMessageAsync()
        {
            Discord.Webhook.DiscordWebhookClient _client = new(_options.Uri);
            await _client.SendMessageAsync();
        }
    }
}
