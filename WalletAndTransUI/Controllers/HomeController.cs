using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WalletAndTransUI.Models;

namespace WalletAndTransUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {_logger = logger;
}


        [HttpGet]//?
        public IActionResult Creat(decimal initialBalance)
        {
            ContentResult creat = new CreatWallet.Create(Guid.NewGuid(), initialBalance);
            return creat;
        }














[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
