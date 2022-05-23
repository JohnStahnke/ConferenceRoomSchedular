using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRS.WebUI.Controllers
{
    public class MeetingRoomAttendeesController : Controller
    {
        private CRS.Domain.ConcreteProcessors.ProcessMeetingRoomAttendees objProcessMRA;
  
        public MeetingRoomAttendeesController()
        {
            objProcessMRA = new CRS.Domain.ConcreteProcessors.ProcessMeetingRoomAttendees();
        }

        // GET: ConferenceRooms
        public ActionResult Index(int selectedMeetingID)
        {
            var objSelectedMeeting = objProcessMRA.MeetingRoomAttendees.Where(ID => ID.MeetingID == selectedMeetingID);
            TempData["SelectedMeetingID"] = selectedMeetingID;
            return View( objSelectedMeeting);
        }

        [Authorize]
        public ActionResult ManagerOverview()
        {
            return View((IEnumerable<CRS.Domain.Abstract.IMeetingRoomAttendee>)objProcessMRA.MeetingRoomAttendees);
        }

        //[HttpGet]
        //public ViewResult Insert()
        //{
        //    return View(new CRS.Domain.ConcreteEntities.MeetingRoomAttendee());
        //}

        //[HttpPost]
        //public ActionResult Insert(CRS.Domain.ConcreteEntities.MeetingRoomAttendee meetingrmAttendee)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        CRS.Domain.ConcreteProcessors.ProcessMeetingRoomAttendees objProcessor;
        //        objProcessor = new CRS.Domain.ConcreteProcessors.ProcessMeetingRoomAttendees();
        //        objProcessor.MeetingRoomAttendees = meetingrmAttendee;
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        // there is something wrong with the data values
        //        return View(meetingrmAttendee);
        //    }
        //}

        //[HttpGet]
        //public ViewResult Update()
        //{
        //    return View(new CRS.Domain.ConcreteEntities.Meeting());
        //}

        //[HttpPost]
        //public ActionResult Update(CRS.Domain.ConcreteEntities.Meeting meeting)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        CRS.Domain.ConcreteProcessors.ProcessMeetings objProcessor;
        //        objProcessor = new CRS.Domain.ConcreteProcessors.ProcessMeetings();
        //        objProcessor.pUpdMeetings(meeting);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        // there is something wrong with the data values
        //        return View(meeting);
        //    }
        //}

        //[HttpGet]
        //public ViewResult Delete()
        //{
        //    return View(new CRS.Domain.ConcreteEntities.Meeting());
        //}

        //[HttpPost]
        //public ActionResult Delete(CRS.Domain.ConcreteEntities.Meeting meeting)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        CRS.Domain.ConcreteProcessors.ProcessMeetings objProcessor;
        //        objProcessor = new CRS.Domain.ConcreteProcessors.ProcessMeetings();
        //        objProcessor.pDelMeetings(meeting);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        // there is something wrong with the data values
        //        return View(meeting);
        //        //return View();
        //    }
        //}
    }
}