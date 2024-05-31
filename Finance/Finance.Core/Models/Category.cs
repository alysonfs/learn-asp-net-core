namespace Finance.Core.Models;

public class Category
{
  public long Id { get; set; } // Mudar para uuid com Ulid
  public string Title { get; set; } = string.Empty;
  public string UserId { get; set; } = string.Empty;
  public string? Description { get; set; }
}