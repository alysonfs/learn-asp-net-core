using Xunit;
using TodoSolution.Domain.UseCase;
using TodoSolution.Domain.UseCase.Interfaces;
using TodoSolution.Domain.Entities;
using TodoSolution.Infra;

namespace TodoSolution.Tests;

public class CreateUserUseCaseTest
{
    private readonly UUIDUlidGenerator _uuidGenerator;
    private readonly UCCreateUser _sut;

    public CreateUserUseCaseTest()
    {
        _uuidGenerator = new UUIDUlidGenerator();
        _sut = new UCCreateUser(_uuidGenerator);
    }

    [Fact]
    public void ExecuteAsync_ShouldCreateUser_WhenDataIsValid()
    {
        // Arrange
        var name = "any_name";
        var email = "any_email@email.com";
        var password = "any_password";
        

        // Act
        var user = _sut.ExecuteSync(name, email, password);
        Console.WriteLine(user.Id);
        // Assert
        Assert.NotNull(user.Id);
        Assert.Equal(name, user.Name);
        Assert.Equal(email, user.Email);
        Assert.Equal(password, user.Password);
    }
}