using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using MessageClient.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MessageClient.Controllers
{
	public class MessagesController : Controller
	{

		public IActionResult Index()
		{
			var allMessages = Message.GetMessages();
			return View(allMessages);
		}

		public ActionResult Details(int id)
		{
			var thisMessage = Message.GetMsgDetails(id);
			return View(thisMessage);
		}

		public ActionResult Create()
		{
      var groups = Group.GetGroups();
			ViewBag.GroupId = new SelectList(groups, "GroupId", "Name");
			return View();
		}

		[HttpPost]
		public ActionResult Create(Message message, int GroupId)
		{
			if (GroupId != 0)
			{
				message.GroupId = GroupId;
			}
			Message.PostMsg(message);
      return RedirectToAction("Details", new {id = message.MessageId});
		}

		public ActionResult Edit(int id)
		{
			var thisMessage = Message.GetMsgDetails(id);
			var groups = Group.GetGroups();
			ViewBag.GroupId = new SelectList(groups, "GroupId", "Name");
			return View(thisMessage);
		}

		[HttpPost]
    public ActionResult Edit(Message message)
    {
      Message.PutMsg(message);
      return RedirectToAction("Details", new { id = message.MessageId });
    }

    [HttpPost]
    public ActionResult Delete(int id)
    {
      Message.DeleteMsg(id);
      return RedirectToAction("Index");
    }
	}
}