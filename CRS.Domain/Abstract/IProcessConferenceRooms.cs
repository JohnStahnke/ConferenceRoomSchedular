using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRS.Domain.Abstract
{
    //using a C# interface to abstract the definition of the Processor functionality from its implementation
    public interface IProcessConferenceRooms
    {
        IEnumerable<ConcreteEntities.ConferenceRoom> ConferenceRooms { get;}
    
        int InsConferenceRooms(ConcreteEntities.ConferenceRoom ConferenceRoom);
        // @ConferenceRoomName, @ConferenceRoomFloor, @ConferenceRoomLocation

        int UpdConferenceRooms(ConcreteEntities.ConferenceRoom ConferenceRoom);
        //@ConferenceRoomID, @ConferenceRoomName, @ConferenceRoomFloor, @ConferenceRoomLocation

        int pDelConferenceRooms(int conferenceRmID);
        //@ConferenceRoomID
    }
}

