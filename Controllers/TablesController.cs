using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminKitTheme.Controllers
{
    [Route("/tables")]
    public class TablesController : Controller
    {
        [Route("/tables")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
