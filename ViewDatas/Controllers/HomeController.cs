using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ViewDatas.Models;

namespace ViewDatas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {

            var model = new HomeModel
            {
                Name = "Bishow",
                Age = 15
            };

            ViewBag.Message = "This is message from ViewBag";

            ViewData["Messages"] = "This is message from ViewData";
            TempData["Message"] = "Temp data message";
            return View(model);
        }

        //ViewResult
        public IActionResult Privacy()
        {
            return View();
        }
        //RedirectResult
        public IActionResult RedirectToAnotherAction()
        {
            TempData["Log"] = "This Message from Redirection";
            return RedirectToAction("Error", "Home");
        }

        //JsonResult: 
        public IActionResult GetJsonData()
        {
            var data = new { Name = "John", Age = 30 };
            return Json(data);
        }

        //ContentResult: 
        public IActionResult PlainText()
        {
            return Content("This is plain text content.", "text/plain");
        }

        //FileResult
        public IActionResult DownloadFile()
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "example.txt");

            // Check if the file exists
            if (System.IO.File.Exists(filePath))
            {
                // Serve the file as a download
                return PhysicalFile(filePath, "application/pdf", "example.txt");
            }
            else
            {
                // File not found, return NotFound result
                return NotFound();

              
            }
        }
        

        public IActionResult ShowPartial()
        {
            return PartialView("_TestPartial");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
