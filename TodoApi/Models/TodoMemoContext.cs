using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class TodoMemoContext : DbContext
{
    public TodoMemoContext(DbContextOptions<TodoMemoContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}