using Telegram.Bot;
using Telegram.Bot.Types;

namespace ExpertWebApplication.Areas.TelegramBot.Models.Commands
{
    public class Help:Command
    {
        public override string Name => "/help";
        public override string State => null;
        public override void Execute(Message message, TelegramBotClient client)
        {
            client.SendTextMessageAsync(message.Chat.Id, "Здоровий дядько, а помощі просиш");
        }
    }
}