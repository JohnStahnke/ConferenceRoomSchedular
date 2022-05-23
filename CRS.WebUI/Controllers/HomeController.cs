using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRS.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private CRS.Domain.Abstract.IProcessMeetings objProcessor;

        public HomeController()
        {
            //You need to create your own object if you are not using DI (Ninject)
            objProcessor = new CRS.Domain.ConcreteProcessors.ProcessMeetings();
        }

        #region Select
        /// <summary>
        /// Used to presents a list of Attendee objects in a web page
        /// </summary>
        /// <returns>An collection of IAttendee compatible objects</returns>
        public ActionResult Index()
        {
            return View((IEnumerable<CRS.Domain.ConcreteEntities.Meeting>)objProcessor.Meetings);
        }

        //public ActionResult MeetingDetails(int SelectedMeetingID)
        //{
        //    CRS.Domain.Abstract.IMeetingRoomAttendee objSelectedMeeting = objProcessor.MeetingsRoomsAttendees.FirstOrDefault(ID => ID.ConferenceRoomID == SelectedMeetingID);
        //    return View(objSelectedMeeting);
        //} 
        #endregion
    }
}