using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using artec.Models;

namespace artec.Controllers
{
    public class PinturasController : Controller
    {
        public PinturasController()
        {
        }

        public IActionResult Ir()
        {
            return View();
        }
    }
}