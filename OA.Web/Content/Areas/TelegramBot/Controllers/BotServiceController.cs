using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using ExpertWebApplication.Areas.TelegramBot.Models;
using ExpertWebApplication.Areas.TelegramBot.Models.Commands;
using Telegram.Bot.Types;

namespace ExpertWebApplication.Areas.TelegramBot.Controllers
{
    public class BotServiceController : ApiController
    {
        [Route(@"api/botservice/update")] //webhook uri part
        public async Task<OkResult> Update([FromBody]Update update)
        {
            var commands = Bot.Commands;
            var message = update.Message;
            var client = await Bot.Get();

            bool executed = false;

            var currentState = Bot.clientStates.Find(x => x.Id == message.Chat.Id);
            if (currentState == null || message.Text =="/start")
            {
                new Hello().Execute(message, client);
                executed = true;
            }
            else
            {
                foreach (var command in commands)
                {
                    if (command.Contains(message.Text, currentState.State.ToString()))
                    {
                        command.Execute(message, client);
                        executed = true;
                        break;
                    }
                }
            }
            if (!executed)
            {
                string path = @"https://i.makeagif.com/media/7-05-2015/PyIubI.gif";
               await client.SendAnimationAsync(message.Chat.Id, animation:path  , caption:"Я не екстрасенс, а бот. Але, ти, мабуть, написав якусь дурницю...");
            }
            return Ok();
        }
    }
}