using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Domain.Abstract
{
    public interface IMeeting
    {
        int MeetingID { get; set; }
        string MeetingSubject { get; set; }
        DateTime MeetingDate { get; set; }
        int MeetingHour { get; set; }
        int ConferenceRoomID { get; set; }
    }
}
