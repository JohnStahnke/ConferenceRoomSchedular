using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Domain.Abstract
{
    public interface IMeetingRoomAttendee
    {
        int MeetingID { get; set; }
        string MeetingSubject { get; set; }
        DateTime MeetingDate { get; set; }
        int MeetingHour { get; set; }
        int ConferenceRoomID { get; set; }
        string ConferenceRoomName { get; set; }
        int ConferenceRoomFloor { get; set; }
        string ConferenceRoomLocation { get; set; }
        int AttendeeID { get; set; }
        string AttendeeName { get; set; }
        string AttendeeEmail { get; set; }
        string AttendeePhone { get; set; }
    }
}
