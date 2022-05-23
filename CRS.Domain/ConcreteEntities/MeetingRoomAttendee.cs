using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Domain.ConcreteEntities
{
    public class MeetingRoomAttendee : CRS.Domain.Abstract.IMeetingRoomAttendee
    {
        public int MeetingID{get; set;}


        public string MeetingSubject { get; set; }


        public DateTime MeetingDate { get; set; }

        public int MeetingHour { get; set; }

        public int ConferenceRoomID { get; set; }

        public string ConferenceRoomName { get; set; }

        public int ConferenceRoomFloor { get; set; }

        public string ConferenceRoomLocation { get; set; }

        public int AttendeeID { get; set; }

        public string AttendeeName { get; set; }

        public string AttendeeEmail { get; set; }

        public string AttendeePhone { get; set; }
    }
}
