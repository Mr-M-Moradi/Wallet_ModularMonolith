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
    }
}
