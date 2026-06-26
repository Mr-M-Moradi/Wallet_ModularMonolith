using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public decimal Balance { get; set; }


        public readonly object LockObject = new object();





    }
}
