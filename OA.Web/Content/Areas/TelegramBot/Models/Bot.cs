using System.Collections.Generic;
using System.Threading.Tasks;
using ExpertWebApplication.Areas.TelegramBot.Models.Commands;
using Telegram.Bot;

namespace ExpertWebApplication.Areas.TelegramBot.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;
        private static List<Command> commandsList;
        public static List<ChatStates> clientStates = new List<ChatStates>();

        public static IReadOnlyList<Command> Commands => commandsList.AsReadOnly();
        public static async Task<TelegramBotClient> Get()
        {
            if (client != null)
            {
                return client;
            }

            commandsList = new List<Command>();

            commandsList.Add(new Hello());
            commandsList.Add(new DisplayExpertise());
            commandsList.Add(new GetExpertise());
            commandsList.Add(new Sessions());
            commandsList.Add(new Bye());
            commandsList.Add(new Help());


            client = new TelegramBotClient(AppSettings.Key);
            var hook = string.Format(AppSettings.Url, "api/botservice/update");
            await client.SetWebhookAsync(hook);

            return client;
        }
    }
}