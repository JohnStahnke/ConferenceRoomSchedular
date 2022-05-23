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
   public class ConferenceRoom : CRS.Domain.Abstract.IConferenceRoom
    {
       [HiddenInput(DisplayValue = false)]//added in 11-7 
       public int ConferenceRoomID
       {get;set;}

       [Required(ErrorMessage = "Please enter a Conference Room name")]//added in 11-13
        public string ConferenceRoomName
       {get;set;}


       [Required(ErrorMessage = "Please enter a Conference Room Floor")]//added in 11-13
        public int ConferenceRoomFloor
       {get;set;}


       [Required(ErrorMessage = "Please enter a Conference Room Location")]//added in 11-13
        public string ConferenceRoomLocation
       {get;set;}
    }
}
