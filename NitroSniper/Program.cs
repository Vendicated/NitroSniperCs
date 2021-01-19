using DSharpPlus;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace NitroSniper
{
    public class Program
    {

        private DiscordClient[] _clients;
        private Config _config;
        public static void Main(string[] args)
        {
            new Program(args).InitAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public Program(string[] args)
        {
            _config = JsonConvert.DeserializeObject<Config>(File.ReadAllText("./config.json"));
        }

        public async Task InitAsync()
        {
            foreach (var slaveToken in _config.Slaves)
            {
                DiscordClient client;
                client = new DiscordClient(new DiscordConfiguration() { Token = slaveToken, TokenType = TokenType.User });

                await client.ConnectAsync();
            }

            await Task.Delay(-1);
        }

    }


    public class Config
    {
        public string Master {get; set;}
        public string UserAgent { get; set; }
        public string Webhook { get; set; }
        public System.Collections.Generic.IList<string> Slaves { get; set; }
}