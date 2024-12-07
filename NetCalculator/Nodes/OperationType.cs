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
}