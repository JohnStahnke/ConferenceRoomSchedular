using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Domain.Abstract
{
    public interface IProcessAttendees
    {
        IEnumerable<ConcreteEntities.Attendee> Attendees { get; }

        int InsAttendees(ConcreteEntities.Attendee Attendee);
        // @AttendeeName, @AttendeeEmail, @AttendeePhone

        int UpdAttendees(ConcreteEntities.Attendee Attendee);
        //@AttendeeID, @AttendeeName, @AttendeeEmail, @AttendeePhone

        int pDelAttendees(int AttendeeID);
        //@AttendeeID
    }
}
