using Telegram.Bot;
using Telegram.Bot.Types;

namespace ExpertWebApplication.Areas.TelegramBot.Models.Commands
{
    public class Bye:Command
    {
        public override string Name => "/bye";

        public override string State => null;

        public override void Execute(Message message, TelegramBotClient client)
        {
            client.SendTextMessageAsync(message.Chat.Id, "Пока, бандіт, приходь ще...");
        }
    }
}