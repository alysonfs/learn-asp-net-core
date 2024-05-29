using TodoSolution.Domain.Entities;

namespace TodoSolution.Tests;

public class UnitTodoTest
{
    [Fact]
    public void CreateTodo()
    {
        var title = "Test Todo";
        // Arrange
        var todo = new Todo { Title = title };

        // Act
        var result = todo.Title;

        // Assert
        Assert.Equal("Test Todo", result);
    }
}