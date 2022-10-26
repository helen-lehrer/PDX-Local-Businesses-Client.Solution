using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoard.Models;
using System.Linq;
using System;

public IActionResult Index()
{
  var allMessages = Message.GetMessages();
  return View(allMessages);
}