#region Usings
using Microsoft.AspNetCore.Mvc;
#endregion

namespace TheSharpFactory.Web.Controllers
{
    public class HomeController : Controller
    {              
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }       

    }
}
