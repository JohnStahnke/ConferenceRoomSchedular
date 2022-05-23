using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRS.WebUI.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        //Commented out moved all action methods to Table Controllers
        //public ActionResult Meetings()
        //{
        //    CRS.Domain.ConcreteProcessors.ProcessMeetings mList = new Domain.ConcreteProcessors.ProcessMeetings();

        //    return View(mList);
        //}

        //public ActionResult ConferenceRooms()
        //{
        //    CRS.Domain.ConcreteProcessors.ProcessConferenceRooms mList = new Domain.ConcreteProcessors.ProcessConferenceRooms();

        //    return View(mList);
        //}

        //public ActionResult MeetingRoomAttendees()
        //{
        //    return View();
        //}

        //public ActionResult Attendees()
        //{
        //    CRS.Domain.ConcreteProcessors.ProcessAttendees mList = new Domain.ConcreteProcessors.ProcessAttendees();

        //    return View(mList);
        //}
    }
}