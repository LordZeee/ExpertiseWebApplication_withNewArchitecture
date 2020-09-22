using Telegram.Bot;
using Telegram.Bot.Types;

namespace ExpertWebApplication.Areas.TelegramBot.Models.Commands
{
    public class GetExpertise:Command
    {
        public override string Name => "/getexp";

        public override string State => null;

        public override void Execute(Message message, TelegramBotClient client)
        {
            Bot.clientStates.Find(x=>x.Id == message.Chat.Id).State=Areas.TelegramBot.Models.State.Getexp;


            client.SendTextMessageAsync(message.Chat.Id, "Введіть номер експертизи!");
        }

        
    }
}