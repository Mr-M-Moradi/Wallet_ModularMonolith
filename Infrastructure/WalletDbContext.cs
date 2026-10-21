using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class WalletDbContext : DbContext
    {
        //private readonly WalletDbContext _context =null;
        public WalletDbContext(DbContextOptions<WalletDbContext> options) : base(options)
        {
            //_context = Context;
        }

        public DbSet<Wallet> Wallets { get; set; }


        ////گرفتن کانکشن استرینگ
        //public AppDbContext(DbContextOptionsBuilder optionsBuilder) : base(options) { optionsBuilder.UseSqlServer(GetConnectionString()); }
	
	// این برای زمانیه پروژه ما mvc نیست و مادلش باید بیلد و کانفیگ بشه 
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

    }
}
