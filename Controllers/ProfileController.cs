using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminKitTheme.Controllers
{
    [Route("/profile")]
    public class ProfileController : Controller
    {
        [Route("/profile")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
