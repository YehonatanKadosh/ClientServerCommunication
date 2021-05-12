using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() { }

        public IActionResult Index() => View();
    }
}