using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using PortlandLocalBusinessesClient.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PortlandLocalBusinessesClient.Controllers
{
	public class BusinesssController : Controller
	{

		public IActionResult Index()
		{
			List<Business> allBusinesses = Business.GetBusinesses();
			return View(allBusinesses);
		}

		// public ActionResult Details(int id)
		// {
		// 	var thisBusiness = Business.GetMsgDetails(id);
		// 	return View(thisBusiness);
		// }

		// public ActionResult Create()
		// {
    //   var neighborhoods = Neighborhood.GetNeighborhoods();
		// 	ViewBag.NeighborhoodId = new SelectList(neighborhoods, "NeighborhoodId", "Name");
		// 	return View();
		// }

		// [HttpPost]
		// public ActionResult Create(Business business, int NeighborhoodId)
		// {
		// 	if (NeighborhoodId != 0)
		// 	{
		// 		business.NeighborhoodId = NeighborhoodId;
		// 	}
		// 	Business.PostMsg(business);
    //   return RedirectToAction("Details", new {id = business.BusinessId});
		// }

		// public ActionResult Edit(int id)
		// {
		// 	var thisBusiness = Business.GetMsgDetails(id);
		// 	var neighborhoods = Neighborhood.GetNeighborhoods();
		// 	ViewBag.NeighborhoodId = new SelectList(neighborhoods, "NeighborhoodId", "Name");
		// 	return View(thisBusiness);
		// }

		// [HttpPost]
    // public ActionResult Edit(Business business)
    // {
    //   Business.PutMsg(business);
    //   return RedirectToAction("Details", new { id = business.BusinessId });
    // }

    // [HttpPost]
    // public ActionResult Delete(int id)
    // {
    //   Business.DeleteMsg(id);
    //   return RedirectToAction("Index");
    // }
	}
}