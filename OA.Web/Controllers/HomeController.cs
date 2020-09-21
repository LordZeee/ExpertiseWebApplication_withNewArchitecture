using OA.Domain.Core.Entitys;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data;
using OA.Services.Interfaces;
using PagedList;
using System.Linq;
using System.Web.Mvc;

namespace OA.Web.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork unitOfWork;
        IExpertise expertiseOperator1;
        public HomeController(IExpertise expertise)
        {
            unitOfWork = new UnitOfWork();
            expertiseOperator1 = expertise;
        }
        public ActionResult Index(int? page)
        {
            int PageSize = 5;
            int pageNumber = (page ?? 1);

            var allexpertise = unitOfWork.tbExpertizy.GetExpertizyList().OrderByDescending(x => x.N1);
            return View(allexpertise.ToPagedList(pageNumber, PageSize));
        }

        public ActionResult Create()
        {
            var allexpertise = unitOfWork.tbExpertizy.GetExpertizyList();
            expertiseOperator1.CreateExpertise(allexpertise);
            return View();
        }
    }
}