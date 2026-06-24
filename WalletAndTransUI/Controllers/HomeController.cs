using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WalletAndTransUI.Models;
//using MediatR;

namespace WalletAndTransUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger)
        {_logger = logger;
}


        [HttpGet]//?
        public IActionResult Creat(decimal initialBalance)
        {
            ContentResult creat = new CreatWallet.Create(Guid.NewGuid(), initialBalance);
            return creat;
        }

        //[HttpGet("{id:guid}")]//?
        // public async Task<IActionResult> Deposit(Guid id, [FromBody] DepositRequest request)//?
        //{
        //    //var command = new DepositCommand(id, request.Amount, request.Currency);
        //    //var result = await _mediator.Send(command);

        //    //if (!result.IsSuccess)
        //    //    return BadRequest(result.Error);

        //    //return Ok(result.Data);
        //}


        //public async Task<IActionResult> GetWallets(Guid id)
        //{
        //    //var query = new GetWalletQuery(id);
        //    //var result = await _mediator.Send(query);

        //    return Ok(result);
        //}


//public record DepositRequest(decimal Amount, string Currency);






[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
