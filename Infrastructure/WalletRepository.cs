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
    //interfaceپیاده سازی 
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
            //try { } 
            //catch { throw new ArgumentException("ولت ذخیره نشد"); }
            
            return newWallet;
        }



        //        public async Task<Wallet?> GetWalletByIdAsync(Guid id)
        //        {
        //            return await _context.Wallets
        //                .FirstOrDefaultAsync(w => w.Id == id);
        //        }

        //        public async Task<Wallet?> GetWalletByUserAsync(string userId)
        //        {
        //            return await _context.Wallets
        //                .FirstOrDefaultAsync(w => w.UserId == userId);
        //        }


    }
}
