using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CreateWallet 
    {
        private readonly IWalletRepository _walletRepository;

        public CreateWallet(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }


        public bool Create(string userID, decimal initialBalance)
        {
            var newWallet = new Wallet
            {
                Id = Guid.NewGuid(),
                UserId = userID,
                Balance = initialBalance
            };
            _walletRepository.Create(newWallet);

            return true;
        }
    }
}

