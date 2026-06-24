using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using Domain.Wallet;

namespace Infrastructure
{
    public class WalletDbContext : DbContext //, IWalletRepository
    {
        private readonly WalletDbContext _context;
        public WalletDbContext( DbContextOptions<WalletDbContext> options) : base(options)
        {
            //_context = context;
        }

        //public DbSet<Wallet> Wallets { get; set; }
        ////?
        //public AppDbContext(DbContextOptionsBuilder optionsBuilder) : base(options) { optionsBuilder.UseSqlServer(GetConnectionString()); }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Wallet>(entity =>{
        //        entity.HasKey(w => w.Id);
        //        entity.Property(w => w.UserId).IsRequired();
        //        entity.OwnsOne(w => w.Balance, money =>
        //        {
        //            money.Property(m => m.Value).HasColumnName("Balance");
        //            money.OwnsOne(m => m.Currency, currency =>{
        //                currency.Property(c => c.Code).HasColumnName("Currency");
        //            });
        //        });
        //    });
        //}
        //me
        //        public void CreateNewWallet(Guid userID, decimal initialBalance)
        //        {
        //            var wallet = new Wallet
        //            {
        //                WalletId = Guid.NewGuid(),
        //                UserId = userId,
        //                Balance = initialBalance
        //            };

        //            _context.TryAdd(wallet);
        //        }
        //    }
        //}

    }
}
// Wallet.Infrastructure/Persistence/Repositories/WalletRepository.cs
//namespace Wallet.Infrastructure.Persistence.Repositories;

//public class WalletRepository : IWalletRepository
//    {

//        public async Task<Wallet?> GetByIdAsync(Guid id)
//        {
//            return await _context.Wallets
//                .FirstOrDefaultAsync(w => w.Id == id);
//        }

//        public async Task<Wallet?> GetByUserIdAsync(string userId)
//        {
//            return await _context.Wallets
//                .FirstOrDefaultAsync(w => w.UserId == userId);
//        }

//        public async Task AddAsync(Wallet wallet)
//        {
//            await _context.Wallets.AddAsync(wallet);
//        }

//        public Task UpdateAsync(Wallet wallet)
//        {
//            _context.Wallets.Update(wallet);
//            return Task.CompletedTask;
//        }
//    }
