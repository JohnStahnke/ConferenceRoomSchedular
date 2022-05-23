using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRS.Domain.ConcreteEntities;

namespace CRS.WebUI.Controllers
{
    public class AttendeesController : Controller
    {
        private CRS.Domain.ConcreteProcessors.ProcessAttendees objProcessAttendee;
  
        public AttendeesController()
        {
            objProcessAttendee = new CRS.Domain.ConcreteProcessors.ProcessAttendees();
        }

        // GET: Attendees
        [Authorize] //put this in from RR final could not get login in
        public ActionResult Index()
        {
            return View((IEnumerable<CRS.Domain.ConcreteEntities.Attendee>)objProcessAttendee.Attendees);
        }

        //RR final
        [HttpPost]
        public ActionResult Attend(int SelectedMeetingID)
        {
            TempData["SelectedMeetingID"] = SelectedMeetingID;
            return View((IEnumerable<CRS.Domain.ConcreteEntities.Attendee>)objProcessAttendee.Attendees);
        }

        //RR Final I had no parameter, I was just returning a new Entity.Attendee
        [HttpGet]
        public ViewResult Insert(int SelectedMeetingID)
        {
            TempData["SelectedMeetingID"] = SelectedMeetingID;
            return View(new CRS.Domain.ConcreteEntities.Attendee());
        }

        [HttpPost]
        public ActionResult Insert(CRS.Domain.ConcreteEntities.Attendee attendee, int SelectedMeetingID)
        {
            if (ModelState.IsValid)
            {
                objProcessAttendee.InsAttendees(attendee);
                if (SelectedMeetingID == 0) //Added RR Final
                {
                    return RedirectToAction("Index", "Attendees"); // I did not have the controller listed
                }
                return RedirectToAction("Index", "MeetingRoomsAttendees", new { SelectedMeetingID = SelectedMeetingID });
            }
            else
            {
                // there is something wrong with the data values
                return View(attendee);
            }
        }

        [HttpGet]
        public ViewResult Update(int SelectedAttendeeID)
        {
            CRS.Domain.Abstract.IAttendee objSelectedAttendee = objProcessAttendee.Attendees.FirstOrDefault(ID => ID.AttendeeID == SelectedAttendeeID);
            return View(objSelectedAttendee);
        }

        [HttpPost]
        public ActionResult Update(CRS.Domain.ConcreteEntities.Attendee attendee)
        {
            if(ModelState.IsValid)
            {
                objProcessAttendee.UpdAttendees(attendee);
                TempData["Message"] = string.Format("Attendee {0} was updated!", attendee.AttendeeID);
                return RedirectToAction("Index");
            }
            else
            {
                return View(attendee);
            }
        }

        [HttpPost]
        public ActionResult Delete(int attendeeID)
        {
            if(ModelState.IsValid)
            {
                objProcessAttendee.pDelAttendees(attendeeID);
                TempData["Message"] = string.Format("Attendee {0} was deleted!", attendeeID);
                return RedirectToAction("Index");
            }
            else
            {
                return View(attendeeID);
            }
        }
    }
}