using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Domain.Abstract
{
    public interface IProcessMeetingRoomAttendees
    {
        IEnumerable<ConcreteEntities.MeetingRoomAttendee> MeetingRoomAttendees { get; }
    }
}
