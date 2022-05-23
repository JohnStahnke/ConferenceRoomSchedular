using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Domain.Abstract
{
    public interface IConferenceRoom
    {
        int ConferenceRoomID { get; set; }
        string ConferenceRoomName { get; set; }
        int ConferenceRoomFloor { get; set; }
        string ConferenceRoomLocation { get; set; }
    }
}
