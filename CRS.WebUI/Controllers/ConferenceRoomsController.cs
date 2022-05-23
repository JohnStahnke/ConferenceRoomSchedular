using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Need to add this for the Processor to work
//PM>Install-Package EntityFramework -Version 6.1.3 -projectname CRS.WebUI

namespace CRS.WebUI.Controllers
{
    public class ConferenceRoomsController : Controller
    {
        private CRS.Domain.ConcreteProcessors.ProcessConferenceRooms objProcessCR;
  
        public ConferenceRoomsController()
        {
            objProcessCR = new CRS.Domain.ConcreteProcessors.ProcessConferenceRooms();
        }

        // GET: ConferenceRooms
        public ActionResult Index()
        {
            return View(( IEnumerable<CRS.Domain.ConcreteEntities.ConferenceRoom>)objProcessCR.ConferenceRooms);
        }

        //RR Final, I did not provide any Detail support
        public ActionResult ConferenceRoomDetails(int SelectedConferenceRoomID)
        {
            CRS.Domain.Abstract.IConferenceRoom objSelectedConferenceRoom = objProcessCR.ConferenceRooms.FirstOrDefault(ID => ID.ConferenceRoomID == SelectedConferenceRoomID);
            return View(objSelectedConferenceRoom);
        } 

        [HttpGet]
        public ViewResult Insert()
        {
            return View(new CRS.Domain.ConcreteEntities.ConferenceRoom());
        }

        [HttpPost]
        public ActionResult Insert(CRS.Domain.ConcreteEntities.ConferenceRoom ConfernceRoom)
        {
            if (ModelState.IsValid)
            {
                objProcessCR.InsConferenceRooms(ConfernceRoom);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(ConfernceRoom);
            }
        }

       

        [HttpGet]
        public ViewResult Update(int selectedCRID)
        {
            //This needs to be able to handle ConferenceRoom ID then populate fields with ConfRoom to update
            CRS.Domain.Abstract.IConferenceRoom objSelectedConferenceRoom = objProcessCR.ConferenceRooms.FirstOrDefault(ID => ID.ConferenceRoomID == selectedCRID);
            return View(objSelectedConferenceRoom);
        }

        [HttpPost]
        public ActionResult Update(CRS.Domain.ConcreteEntities.ConferenceRoom conferenceRoom)
        {
            if (ModelState.IsValid)
            {
                objProcessCR.UpdConferenceRooms(conferenceRoom);
                TempData["Message"] = string.Format("Conference Room {0} was updated!", conferenceRoom.ConferenceRoomID);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(conferenceRoom);
            }
        }

        [HttpGet]
        public ViewResult Delete()
        {
            return View(new CRS.Domain.ConcreteEntities.ConferenceRoom());
        }

        [HttpPost]
        public ActionResult Delete(int conferenceRmID)
        {

            if (ModelState.IsValid)
            {

                objProcessCR.pDelConferenceRooms(conferenceRmID);
                TempData["Message"] = string.Format("Conference Room {0} was deleted!", conferenceRmID); // RR Final Did not provide message support
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(conferenceRmID);
                //return View();
            }
        }
    }
}