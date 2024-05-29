using System;
using NUlid;

using TodoSolution.Domain.UseCase.Interfaces;

namespace TodoSolution.Infra;

public class UUIDUlidGenerator : IUUIDGenerator
{
    public UUIDUlidGenerator(){}
    public string Generate()
    {
        var myulid = Ulid.NewUlid(DateTime.Now);
        return myulid.ToString();
    }
}