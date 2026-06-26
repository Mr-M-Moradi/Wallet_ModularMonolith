using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CreateWallet
    {
        public bool Create(Guid userID, decimal initialBalance)
        {
            CreateNewWallet(userID, initialBalance);
        }
    }
}


/*


using MediatR;
using Wallet.Application.DTOs;

namespace Wallet.Application.UseCases.Wallets;

public record DepositCommand(
    Guid WalletId,
    decimal Amount,
    string CurrencyCode
) : IRequest<Result<WalletDto>>;



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
        var wallet = await _walletRepository.GetByIdAsync(request.WalletId);
        if (wallet is null)
            return Result<WalletDto>.Failure("کیف پول یافت نشد");

        var currency = Currency.FromCode(request.CurrencyCode);
        var amount = new Money(request.Amount, currency);

        wallet.Deposit(amount);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var dto = WalletMapper.ToDto(wallet);
        return Result<WalletDto>.Success(dto);
    }
}




namespace Wallet.Application.DTOs;

public record WalletDto(
    Guid Id,
    string UserId,
    decimal Balance,
    string Currency,
    bool IsActive
);
*/