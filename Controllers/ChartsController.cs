using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminKitTheme.Controllers
{
    [Route("charts")]
    public class ChartsController : Controller
    {
        [Route("charts")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
