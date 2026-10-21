using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CreateWallet 
    {
        private readonly IWalletRepository _walletRepository;

        public CreateWallet(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }


        //آبجکت اینجا از روی انتیتی و ولیوی کاربر ساخته میشه و ازطریق اینجکشن برای متد اینترفیس ست میشه واون متد توسط زیرساخت پیاده سازی میشه
        // دسترس کنترولر یوآی
        public bool Create(string userID, decimal initialBalance)
        {
            var newWallet = new Wallet
            {
                Id = Guid.NewGuid().ToString(),
                UserId = userID,
                Balance = initialBalance
            };
            _walletRepository.Create(newWallet);

            return true;
        }
    }
}


/*

// Wallet.Application/UseCases/Wallets/DepositCommand.cs

using MediatR;
using Wallet.Application.DTOs;

namespace Wallet.Application.UseCases.Wallets;

public record DepositCommand(
    Guid WalletId,
    decimal Amount,
    string CurrencyCode
) : IRequest<Result<WalletDto>>;



// Wallet.Application/UseCases/Wallets/DepositHandler.cs
namespace Wallet.Application.UseCases.Wallets;

public class DepositHandler : IRequestHandler<DepositCommand, Result<WalletDto>>
{
    private readonly IWalletRepository _walletRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DepositHandler(IWalletRepository walletRepository, IUnitOfWork unitOfWork)
    {
        _walletRepository = walletRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<WalletDto>> Handle(DepositCommand request, CancellationToken cancellationToken)
    {
        // 1. Get wallet from domain
        var wallet = await _walletRepository.GetByIdAsync(request.WalletId);
        if (wallet is null)
            return Result<WalletDto>.Failure("کیف پول یافت نشد");

        // 2. Create value object
        var currency = Currency.FromCode(request.CurrencyCode);
        var amount = new Money(request.Amount, currency);

        // 3. Execute domain logic
        wallet.Deposit(amount);

        // 4. Save changes
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        // 5. Return result
        var dto = WalletMapper.ToDto(wallet);
        return Result<WalletDto>.Success(dto);
    }
}




// Wallet.Application/DTOs/WalletDto.cs
namespace Wallet.Application.DTOs;

public record WalletDto(
    Guid Id,
    string UserId,
    decimal Balance,
    string Currency,
    bool IsActive
);
*/