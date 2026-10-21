/*
نیاز به 3تا انتیتی نیست
ثبت تراکنش‌ها در Transaction کافیه
رابطش با ولت 1:n
برای هر تراکنش یک رکورد ثبت میشه توی Transaction 
پراپرتیه Type میشه برای اینکه بگیم تراکنش ما از نوع واریزه یا برداشته (withdrw)
پوینت مثبت اینکه دیگه نیازی نیست یک تیبل داشته باشیم برای تراکنش واریز و یکی دیگه برای برداشت
یا اینکه توی تیبل تراکنش دوتا پراپرتی ولت مبدا و مقصد داشته باشیم
چون ممکنه یکی از عملیات های برداشت یا واریز اصلا سمت ما نباشه و درسیستم دیگه اتفاق بیفته
اینطوری میشه روی دوتا عملیات هم بصورت جدا نظارت کرد
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

    }
}
