using FinCore.Domain.Enums;

namespace FinCore.Domain.Entities.App;

public class AccountTransaction : BaseEntity
{
    public Guid AccountId { get; set; }
    public Account Account { get; set; }
    public TransactionType TransactionType { get; set; }
    public decimal Amount { get; set; }
    public Currency Currency { get; set; }
    public decimal BalanceAfterTransaction { get; set; }
    public string Description { get; set; }

    public string ReferenceNumber { get; set; }

}
