using DiscordRPC;
using System;

namespace UsefulTools
{
    internal class discordStatue
    {
        private string v;

        public discordStatue(string v)
        {
            this.v = v;

            var client = new DiscordRpcClient("791023027260227585");

            if (client.Initialize() == true)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = "Tools",
                    State = v
                });
                Console.WriteLine("DiscordRPC has been enabled!");
            }
            else
            {
                Console.WriteLine("DiscordRPC doesn't work!");
            }

            return;
        }
    }
}