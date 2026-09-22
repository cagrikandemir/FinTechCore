namespace FinCore.Domain.Entities;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreateTime{ get; set; }
    public DateTime ModifyTime { get; set; }
}
