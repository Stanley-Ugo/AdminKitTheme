using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminKitTheme.Controllers
{
    [Route("Map")]
    public class Map_GoogleController : Controller
    {
        [Route("Map")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
