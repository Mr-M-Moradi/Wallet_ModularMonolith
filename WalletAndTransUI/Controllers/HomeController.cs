using Application;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WalletAndTransUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWalletRepository _walletRepository;//ساخت اولین نمونه از اینترفیس برای فرستادنش به کانستراک لایه اپلیکشن، به روش مدیتاتر خودمدیتاتراینو انجام میده

        public HomeController(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }


        [HttpGet]
        public string Creat(string UserId, decimal initialBalance)
        {//اینجا از اپلیکیشن شی ساختم و چون استفادم از اپلیکشن به همین مرحله ختم میشه نیازی نیست به روش دپندنسی باشه
            var createWallet = new CreateWallet(_walletRepository); 
            string result = createWallet.Create(UserId, initialBalance).ToString();
            return result;
        }














    }
}
