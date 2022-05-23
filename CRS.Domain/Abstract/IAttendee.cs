using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Domain.Abstract
{
    public interface IAttendee
    {
      int AttendeeID  {get;set;}
      string AttendeeName  {get;set;}
      string AttendeeEmail {get;set;}
      string AttendeePhone { get; set; }
    }
}
