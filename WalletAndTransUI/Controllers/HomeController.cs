using Application;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//using MediatR;

namespace WalletAndTransUI.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IMediator _mediator;
        private readonly IWalletRepository _walletRepository;//ساخت اولین نمونه از اینترفیس برای فرستادنش به کانستراک لایه اپلیکشن، به روش مدیتاتر خودمدیتاتراینو انجام میده

        public HomeController(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        //localhost:25067/Home/Creat?UserId=001&initialBalance=11
        [HttpGet]
        public string Creat(string UserId, decimal initialBalance)
        {//اینجا از اپلیکیشن شی ساختم و چون استفادم از اپلیکشن به همین مرحله ختم میشه نیازی نیست به روش دپندنسی باشه
            var createWallet = new CreateWallet(_walletRepository); 
            string result = createWallet.Create(UserId, initialBalance).ToString();
            return result;
        }


        //[HttpGet("{id:guid}")]//Deposit سپرده
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





    }
}
