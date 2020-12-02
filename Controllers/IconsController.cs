using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminKitTheme.Controllers
{
    [Route("/icons")]
    public class IconsController : Controller
    {
        [Route("/icons")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
