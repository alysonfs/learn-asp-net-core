using TodoSolution.Domain.Entities;
using TodoSolution.Domain.UseCase.Interfaces;

namespace TodoSolution.Domain.UseCase;

public class UCCreateUser
{
    private readonly IUUIDGenerator _uuidGenerator;
    public UCCreateUser(
        IUUIDGenerator uuidGenerator
    )
    {
        _uuidGenerator = uuidGenerator;
    }
    
    public User ExecuteSync(string name, string email, string password)
    {
        var user = new User(name, email, password);
        user.Id = _uuidGenerator.Generate();
        return user;
    }
}