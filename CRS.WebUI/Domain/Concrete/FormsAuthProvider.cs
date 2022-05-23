using CRS.WebUI.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRS.WebUI.Domain.Concrete
{
    public class FormsAuthProvider : IAuthProvider
    {
        public bool Authenticate(string username, string password)
        {
            bool result = System.Web.Security.FormsAuthentication.Authenticate(username, password);
            if (result)
            {
                System.Web.Security.FormsAuthentication.SetAuthCookie(username, false);
            }
            return result;
        }

    }
    
}