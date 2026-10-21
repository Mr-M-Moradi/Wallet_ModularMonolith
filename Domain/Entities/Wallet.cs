using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities{
    [Table("Wallet")]
    public class Wallet
    {
        [Key]
        public string Id { get; set; }
        public string UserId { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; } = "IRR";

        public readonly object LockObject = new object();

    }
}
