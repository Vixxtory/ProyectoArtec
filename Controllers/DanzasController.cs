using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using artec.Models;

namespace artec.Controllers
{
    public class DanzasController : Controller
    {
        public DanzasController()
        {
        }

        public IActionResult Ir()
        {
            return View();
        }
    }
}