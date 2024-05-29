namespace TodoSolution.Domain.Entities;

public class User
{
  public string? Id { get; set; }

  public string Name {get; set;}

  public string Email {get; set;}

  public string Password {get; set;}

  public User(string name, string email, string password)
  {
    Name = name;
    Email = email;
    Password = password;
  }
}