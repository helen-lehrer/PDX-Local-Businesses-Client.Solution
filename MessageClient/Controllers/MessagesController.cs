using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using MessageClient.Models;

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
			var thisMessage = Message.GetDetails(id);
			return View(thisMessage);
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(Message message)
		{
      var groups = Group.GetGroups();
			ViewBag.GroupSelection = groups;
      return View();
		}
		public ActionResult Edit(int id)
		{
			var thisMessage = Message.GetDetails(id);
			return View(thisMessage);
		}
	}
}