using ClsWrkMembership.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClsWrkMembership.Controllers
{
    public class BankController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Transfer(Bank model)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Index));
            }
            
            return View(model);

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
