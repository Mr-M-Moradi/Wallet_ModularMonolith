using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IWalletRepository
    {

        bool CreateNewWallet(Guid userID, decimal initialBalance);
        //?        Task AddAsync(Wallet wallet);

        // دریافت کیف پول
        //public Wallet GetWallet(Guid walletId);


        //public Task<Wallet?> GetByIdAsync(Guid id);
        //public Task<Wallet?> GetByUserIdAsync(string userId);
        //Task UpdateAsync(Wallet wallet);
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
