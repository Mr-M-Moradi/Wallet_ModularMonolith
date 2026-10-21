using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IWalletRepository
    {

        public Wallet Create(Wallet newWallet);
        //?      Task CreateAsync(Wallet newWallet);


        // دریافت کیف پول
        //public Task<Wallet?> GetWalletByIdAsync(Guid id);
        //public Task<Wallet?> GetWalletByUserAsync(string userId);
    }
}

// Wallet.Domain/ValueObjects/Money.cs!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//namespace Wallet.Domain.ValueObjects;

//public record Money
//{
//    public decimal Value { get; }
//    public Currency Currency { get; }

//    public Money(decimal value, Currency currency)
//    {
//        Value = value;
//        Currency = currency;
//    }

//    public Money Add(Money other)
//    {
//        if (Currency != other.Currency)
//            throw new DomainException("واحد پول متفاوت است");

//        return new Money(Value + other.Value, Currency);
//    }

//    public bool IsLessThan(Money other) => Value < other.Value;
//}
