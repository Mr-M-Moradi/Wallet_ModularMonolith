using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class WalletDbContext : DbContext //, IWalletRepository
    {
        private readonly WalletDbContext _context;
        public WalletDbContext( DbContextOptions<WalletDbContext> options) : base(options)
        {
        }




    }
}





