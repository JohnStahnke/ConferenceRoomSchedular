using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Domain.Abstract
{
    public interface IProcessMeetingAttendees
    {
        IEnumerable<ConcreteEntities.MeetingAttendee> MeetingAttendees { get; }

        int pInsMeetingsAttendees(ConcreteEntities.MeetingAttendee MeetingAttedee);
        //@MeetingID, @AttendeeID

        int pUpdMeetingsAttendees(ConcreteEntities.MeetingAttendee MeetingAttedee);
        //NOT IMPLEMENTED

        int pDelMeetingsAttendees(ConcreteEntities.MeetingAttendee MeetingAttedee);
        //@MeetingID, @AttendeeID
    }
}
