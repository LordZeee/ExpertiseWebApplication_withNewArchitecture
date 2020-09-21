using Ninject.Modules;
using OA.Infrastructure.Business;
using OA.Services.Interfaces;

namespace OA.Web.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IExpertise>().To<ExpertiseOperator1>();
            Bind<IHelperAPI>().To<AccountAuthorization>();
        }
    }
}