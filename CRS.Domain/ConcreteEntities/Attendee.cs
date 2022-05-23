using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//For the Entity Framework
// PM> Install-Package EntityFramework -Version 6.1.
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
//For Annotations and WebUI
//PM> Install-Package Microsoft.Aspnet.Mvc -version 5.2.0 -projectname CRS.Domain
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CRS.Domain.ConcreteEntities
{
    public class Attendee : CRS.Domain.Abstract.IAttendee
    {
        [HiddenInput(DisplayValue = false)]//added in 11-7 
        public int AttendeeID
        { get; set; }

        [Required(ErrorMessage = "Please enter a Name")]//added in 11-13
        public string AttendeeName
        { get; set; }
        [Required(ErrorMessage = "Please enter a Email")]//added in 11-13
        public string AttendeeEmail
        { get; set; }
        [Required(ErrorMessage = "Please enter a Phone Number")]//added in 11-13
        public string AttendeePhone
        { get; set; }
    }
}
