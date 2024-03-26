using TheaterSystem.Domain.Enum;

namespace TheaterSystem.Domain.Entities;

public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public decimal TotalCost { get; set; } = 0.0m;
    public PaymentType PaymentType { get; set; } = PaymentType.Money;
    public int UserId { get; set; } = 0;
    public User User { get; set; } = null!;
}