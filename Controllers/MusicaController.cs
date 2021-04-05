using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using artec.Models;

namespace artec.Controllers
{
    public class MusicaController : Controller
    {
        public MusicaController()
        {
        }

        public IActionResult Ir()
        {
            return View();
        }
    }
}