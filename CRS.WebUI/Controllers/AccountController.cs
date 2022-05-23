//RR Final, I did not get to adding login accounts

using System.Web.Mvc;
using CRS.WebUI.Models;
using CRS.WebUI.Domain.Abstract;
using CRS.WebUI.Domain.Concrete;

namespace CRS.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private IAuthProvider objAP; //Need this to processes security.

        public AccountController()
        {
            objAP = new FormsAuthProvider(); //Need to create an object. (If not using Ninject)         
        }

        public ViewResult Login()
        { return View(); }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (objAP.Authenticate(model.UserName, model.Password)) // Returns True is OK
                {
                   // return Redirect(returnUrl ?? Url.Action("Index", "ManagerOverview")); // Then redirects
                    return Redirect(returnUrl ?? Url.Action("ManagerOverview","MeetingRoomAttendees"));

                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or password"); //Or Add Error
                    return View();
                }
            }
            else
            { return View(); }
        }//end Login()
    }//end class
}//end namespace