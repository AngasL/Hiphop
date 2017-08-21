using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hiphop.Web.Models;
using Hiphop.Services;

namespace Hiphop.Web.Controllers
{
    public class HomeController : Controller
    {
		private readonly ITestService _service;

		public HomeController(ITestService service)
		{
			_service = service;
		}

        public IActionResult Index()
        {
			var user = _service.GetUserById(1);

			return View(user);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
