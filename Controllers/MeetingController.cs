using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RolesApp.Models;
using Microsoft.EntityFrameworkCore;
using RolesApp.Models.Meeting;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace RolesApp.Controllers
{
    public class MeetingController : Controller
    {
        private ApplicationContext _context;
        public MeetingController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult AddMeeting()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMeeting(MeetingModel model)
        {
            NameMeetingEvent meeting = new NameMeetingEvent
            {
                NameEvent = model.NameEvent
            };
            _context.MeetingEvents.Add(meeting);
            _context.SaveChanges();

            int a = _context.MeetingEvents.Count();

            if (model.HeaderEvent.Count() > 0 && model.NameEvent.Count() > 0)
            {
                for (int i = 0; i < model.HeaderEvent.Count; i++)
                {
                    MeetingInformation information = new MeetingInformation
                    {
                        MeetingID = _context.MeetingEvents.Count(),
                        Header = model.HeaderEvent[i],
                        Context = model.ContextEvent[i]
                    };
                    _context.MeetingInformations.Add(information);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("GetAllMeeting");
        }

        [HttpGet]
        public IActionResult GetAllMeeting()
        {
            return View(_context.MeetingEvents.ToList());
        }

        public IActionResult GetInfoAboutMeeting(int? EventId)
        {
            NameMeetingEvent SelectedMeeting = _context.MeetingEvents.Single(p => p.Id == EventId);

            List<MeetingInformation> SelectedMeetingInfo = new List<MeetingInformation>();

            foreach(var element in _context.MeetingInformations)
            {
                if (element.MeetingID == SelectedMeeting.Id)
                {
                    SelectedMeetingInfo.Add(element);

                }
            }

            ViewBag.EventId = EventId; //I'm sorry for ViewBag :(
            return View(SelectedMeetingInfo);
        }

        public IActionResult RegistrationOnMeeting(int EventId)
        {
            bool isRegistered = false;
            string NameUser =  HttpContext.User.Identity.Name;
            ListRegistrUsersOnEvent record = new ListRegistrUsersOnEvent();
            foreach(var user in _context.Users)
            {
                if (user.Name == HttpContext.User.Identity.Name)
                    record.IdUser = user.Id;
            }
            record.IdMeeting = EventId;

            foreach(var user in _context.listRegistrUsersOnEvents)
            {
                if (record.IdUser == user.IdUser)
                    isRegistered = true;
 
            }
            if (!isRegistered)
            {
                _context.listRegistrUsersOnEvents.Add(record);
                _context.SaveChanges();
            }
            else
                Response.WriteAsync("<script>alert('You are registered on this Meeting!')</script>");
            return RedirectToAction("GetAllMeeting");
        }
    }
}