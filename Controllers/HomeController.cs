using Fatwa_AgentScreen_Pop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fatwa_AgentScreen_Pop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index([FromQuery] string p, string c, string l)
        {
            _logger.LogInformation($"parameter received from the current call +\r\n  \"ANI : - \" {p} \r\n  \"Deparment : - \\n\" {c} \r\n \"langauge : - \\n\" {l});"); 
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}