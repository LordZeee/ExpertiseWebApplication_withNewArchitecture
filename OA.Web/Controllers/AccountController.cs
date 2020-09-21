using OA.Services.Interfaces;
using OA.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OA.Web.Controllers
{
    public class AccountController : Controller
    {
        IHelperAPI AuthorizationAPI;
        // GET: Account
        public AccountController(IHelperAPI helperAPI)
        {
            AuthorizationAPI = helperAPI;
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(SingInModel model, string returnUrl)
        {
            HttpClient client =  AuthorizationAPI.Initial();
            var postTask = client.PostAsJsonAsync<SingInModel>("authorization", model);
            postTask.Wait();

            var result = postTask.Result;
            var fullUserName = result.Content.ReadAsStringAsync().Result;
            if (result.IsSuccessStatusCode)
            {
                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                // Сессия для сохранения имени пользователя и дальнейшего отображения
                Session["currentUser"] = fullUserName;
                if (Url.IsLocalUrl(returnUrl) && returnUrl != null)
                {

                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.Clear();
                ModelState.AddModelError("", "Введіть логін та пароль");
            }
            return View(model);
        }
    }
}