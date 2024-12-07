using System;
using System.Linq;

namespace NetCalculator.Nodes;

public enum OperationType
{
    Add,
    Sub,
    Mul,
    Div,
    Log,
    Pwr,
    Rt,
    Parenthesis,
    EpwrX,
    Ln,
}

public static class OperationTypeExtension
{
    public static bool IsFunction(this OperationType type)
    {
        return type is OperationType.EpwrX or OperationType.Ln;
    }

    public static bool ShouldImplicitlyMultiply(this OperationType type)
    {
        return !new OperationType[]
        {
            OperationType.Ln,
            OperationType.Log,
            OperationType.Rt,
            OperationType.EpwrX
        }.Contains(type);
    }
}