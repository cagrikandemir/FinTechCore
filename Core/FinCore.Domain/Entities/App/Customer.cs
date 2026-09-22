namespace FinCore.Domain.Entities.App;

public class Customer : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string IdentityNumber { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }

    public ICollection<Account> Accounts { get; set; } = new List<Account>();
}
