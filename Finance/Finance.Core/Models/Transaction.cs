using Finance.Core.Enums;

namespace Finance.Core.Models;

public class Transaction
{
  public long Id { get; set; } // Mudar para uuid com Ulid
  public string Title { get; set; } = string.Empty;
  public DateTime CreateAt { get; set; } = DateTime.Now;
  public DateTime? PaidOrReceivedAt { get; set; }
  public ETransactionType Type { get; set; } = ETransactionType.Withdraw;
  public decimal Amount { get; set; } = 0;
  public long CategoryId { get; set; }
  public Category Category { get; set; } = null!;
  public string UserId { get; set; } = string.Empty;
}