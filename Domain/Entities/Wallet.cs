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


        // برای قفل کردن روی هر کیف پول به صورت مجزا
        public readonly object LockObject = new object();


        //    public void Deposit(decimal amount){
        //        if (amount.Value <= 0)
        //            throw new DomainException("مبلغ باید مثبت باشد");

        //        Balance = Balance.Add(amount);
        //    }

        //    public void Withdraw(decimal amount)
        //    {
        //        if (Balance.IsLessThan(amount))
        //            throw new InsufficientFundsException("موجودی کافی نیست");

        //        Balance = Balance.Subtract(amount);
        //    }
    }
}
