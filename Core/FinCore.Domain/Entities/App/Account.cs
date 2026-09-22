using FinCore.Domain.Enums;

namespace FinCore.Domain.Entities.App;

public class Account : BaseEntity
{
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
    public string AccountNumber { get; set; }
    public Currency Currency { get; set; }
    public decimal Balance { get; set; }
}
