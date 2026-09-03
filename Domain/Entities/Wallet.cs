using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Wallet")]
    public class Wallet
    {
        [Key]
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public decimal Balance { get; set; }


        public readonly object LockObject = new object();

    }
}
