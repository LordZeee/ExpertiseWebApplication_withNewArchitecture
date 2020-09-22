using Telegram.Bot;
using Telegram.Bot.Types;

namespace ExpertWebApplication.Areas.TelegramBot.Models.Commands
{
    public abstract class Command
    {
        public abstract string Name { get; }

        public  abstract  string State { get; }

        public abstract void Execute(Message message, TelegramBotClient client);


        public bool Contains(string command , string state)
        {
            bool result = false;

            if (command!=null && command == Name)
            {
                result = true;
            }
            else
            {
                if (state == State)
                {
                    result = true;
                }
            }
            return result;
        }

    }
}