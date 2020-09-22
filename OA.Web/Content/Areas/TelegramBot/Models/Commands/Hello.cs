using Telegram.Bot;
using Telegram.Bot.Types;

namespace ExpertWebApplication.Areas.TelegramBot.Models.Commands
{
    public class Hello : Command
    {
        public override string Name => "/hello";

        public override string State => null;

        public override void Execute(Message message, TelegramBotClient client)
        {
            if (Bot.clientStates.Exists(x=>x.Id == message.Chat.Id) == false)
            {
                Bot.clientStates.Add(new ChatStates(message.Chat.Id));
            }

            string path = @"https://media.giphy.com/media/YoB1eEFB6FZ1m/giphy.gif";


            client.SendAnimationAsync(message.Chat.Id, animation: path , caption:  "Добрий вечір!");
         
        }
    }
}