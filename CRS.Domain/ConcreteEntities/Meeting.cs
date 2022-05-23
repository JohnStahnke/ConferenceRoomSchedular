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
   public class Meeting : CRS.Domain.Abstract.IMeeting
    {  
       [HiddenInput(DisplayValue = false)]//added in 11-7 
        public int MeetingID
       { get; set; }

       [Required(ErrorMessage = "Please enter a Subject")]//added in 11-13
        public string MeetingSubject
        { get; set; }

       [Required(ErrorMessage = "Please enter a Date")]//added in 11-13
        public DateTime MeetingDate
        { get; set; }

       [Required(ErrorMessage = "Please enter a Starting Hour (24Hr clock)")]//added in 11-13
        public int MeetingHour
        { get; set; }

       [Required(ErrorMessage = "Please enter a Conference Room ID")]//added in 11-13
        public int ConferenceRoomID
        { get; set; }
    }
}
