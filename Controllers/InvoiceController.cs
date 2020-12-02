using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminKitTheme.Controllers
{
    [Route("/invoice")]
    public class InvoiceController : Controller
    {
        [Route("/invoice")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
