using System.ComponentModel.DataAnnotations;
namespace Finance.Core.Requests.Categories;

public class CreateCategoryRequest : Request
{
  [Required(ErrorMessage = "Title is required")]
  [MaxLength(50, ErrorMessage = "Title must be less than 50 characters")]
  public string Title { get; set; } = string.Empty;

  [MaxLength(250, ErrorMessage = "Description must be less than 250 characters")]
  public string? Description { get; set; }
}