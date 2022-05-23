using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRS.WebUI.Controllers
{
    [Authorize]
    public class MeetingsController : Controller
    {
        private CRS.Domain.Abstract.IProcessMeetings objProcessM;
  
        public MeetingsController()
        {
            objProcessM = new CRS.Domain.ConcreteProcessors.ProcessMeetings();
        }

        // GET: ConferenceRooms
        public ActionResult Index()
        {
            return View(( IEnumerable<CRS.Domain.ConcreteEntities.Meeting>)objProcessM.Meetings);
        }

        [HttpGet]
        public ViewResult Insert()
        {
            return View(new CRS.Domain.ConcreteEntities.Meeting());
        }

        [HttpPost]
        public ActionResult Insert(CRS.Domain.ConcreteEntities.Meeting meeting)
        {
            if (ModelState.IsValid)
            {   
                CRS.Domain.ConcreteProcessors.ProcessMeetings objProcessor;
                objProcessor = new CRS.Domain.ConcreteProcessors.ProcessMeetings();
                objProcessor.pInsMeeting(meeting);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(meeting);
            }
        }

        [HttpGet]
        public ViewResult Update()
        {
            return View(new CRS.Domain.ConcreteEntities.Meeting());
        }

        [HttpPost]
        public ActionResult Update(CRS.Domain.ConcreteEntities.Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                CRS.Domain.ConcreteProcessors.ProcessMeetings objProcessor;
                objProcessor = new CRS.Domain.ConcreteProcessors.ProcessMeetings();
                objProcessor.pUpdMeetings(meeting);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(meeting);
            }
        }

        [HttpGet]
        public ViewResult Delete()
        {
            return View(new CRS.Domain.ConcreteEntities.Meeting());
        }

        [HttpPost]
        public ActionResult Delete(CRS.Domain.ConcreteEntities.Meeting meeting)
        {
            
            if (ModelState.IsValid)
            {
                CRS.Domain.ConcreteProcessors.ProcessMeetings objProcessor;
                objProcessor = new CRS.Domain.ConcreteProcessors.ProcessMeetings();
                objProcessor.pDelMeetings(meeting);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(meeting);
                //return View();
            }
        }
        
    }
}