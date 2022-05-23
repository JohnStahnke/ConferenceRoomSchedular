//RR final, did not get login done.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRS.WebUI.Models
{
    public class LoginViewModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string UserName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; }
    }
}