using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Domain.Abstract
{
    public interface IProcessMeetings
    {
        IEnumerable<ConcreteEntities.Meeting> Meetings { get; }

        int pInsMeeting (ConcreteEntities.Meeting Meeting);
        //@MeetingSubject, @MeetingDate, @MeetingHour, @ConferenceRoomID

        int pUpdMeetings(ConcreteEntities.Meeting Meeting);
        //@MeetingID, @MeetingSubject, @MeetingDate, @MeetingHour, @ConferenceRoomID

        int pDelMeetings(ConcreteEntities.Meeting Meeting);
        //@MeetingID
    }
}
