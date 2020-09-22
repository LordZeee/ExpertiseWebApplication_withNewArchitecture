using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace ExpertWebApplication.Areas.TelegramBot.Models.Commands
{
    public class Sessions:Command
    {
        public override string Name => "/sessions";

        public override string State => null;

        public override void Execute(Message message, TelegramBotClient client)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var state in Bot.clientStates)
            {
                sb.Append(state+"\n");
            }

            client.SendTextMessageAsync(message.Chat.Id, sb.ToString());
        }
    }
}