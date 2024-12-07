using System;

namespace NetCalculator.Nodes.Arithmetic;

public class ArithmeticNode(INode operand1, INode operand2, OperationType type) : INode
{
    public double GetValue()
    {
        double d1 = operand1.GetValue();
        double d2 = operand2.GetValue();

        switch (type)
        {
            case OperationType.Add:
                return d1 + d2;
            
            case OperationType.Sub:
                return d1 - d2;
            
            case OperationType.Mul:
                return d1 * d2;
            
            case OperationType.Div:
                return d1 / d2;
            
            case OperationType.Pwr:
                return Math.Pow(d1, d2);
            
            case OperationType.Rt:
                return Math.Pow(d2, 1.0 / d1);
            
            case OperationType.Log:
                return Math.Round(Math.Log(operand1.GetValue(), operand2.GetValue()), 4);
        }

        throw new NotSupportedException("Could not handle Operation type: " + type);
    }
}