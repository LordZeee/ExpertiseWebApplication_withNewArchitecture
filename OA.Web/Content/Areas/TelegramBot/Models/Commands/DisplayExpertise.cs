using System;
using System.Linq;
using ExpertWebApplication.Models.DbContext;
using ExpertWebApplication.Models.Entities;
using Telegram.Bot;
using Message = Telegram.Bot.Types.Message;

namespace ExpertWebApplication.Areas.TelegramBot.Models.Commands
{
    public class DisplayExpertise : Command
    {
        private readonly ExpertContext _db = new ExpertContext();

        public override string Name => null;

        public override string State => "Getexp";

        public override void Execute(Message message, TelegramBotClient client)
        {
            Bot.clientStates.Find(x => x.Id == message.Chat.Id).State = Areas.TelegramBot.Models.State.Nothing;

            int expId;

            if (Int32.TryParse(message.Text, out expId))
            {
                tbExpertizy exp = _db.tbExpertizy.FirstOrDefault(x => x.N1 == expId);

                if (exp != null)
                {
                    client.SendTextMessageAsync(message.Chat.Id, text: exp.tNumEZ);
                    client.SendTextMessageAsync(message.Chat.Id, text: exp.mTitleDoc);
                }
                else
                {
                    client.SendTextMessageAsync(message.Chat.Id, "Експертизи не знайдено!");
                }
            }
            else
            {
                client.SendTextMessageAsync(message.Chat.Id, "Лише арабські цифри, будь ласка! Прийми це до уваги наступного разу!");
            }
        }
    }
}