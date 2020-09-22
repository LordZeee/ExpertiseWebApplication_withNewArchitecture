using System.Web.Mvc;

namespace ExpertWebApplication.Areas.TelegramBot
{
    public class TelegramBotAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TelegramBot";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TelegramBot_default",
                "TelegramBot/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}