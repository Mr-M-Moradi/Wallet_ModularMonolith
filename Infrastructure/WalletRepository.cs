using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class WalletRepository : IWalletRepository
    {
        private readonly WalletDbContext _context = null;
        private readonly DbSet<Wallet> _DbWallets;
        public WalletRepository(WalletDbContext Context)
        {
            _context = Context;
            _DbWallets = Context.Wallets;
        }


        public Wallet Create(Wallet newWallet)
        {
            _DbWallets.Add(newWallet);
             _context.SaveChanges(); 
 
            return newWallet;
        }
    }
}
