using System;

namespace NetCalculator.Nodes.Function;

public class FunctionNode(INode target, OperationType type) : INode
{
    public double GetValue()
    {
        switch (type)
        {
            case OperationType.Ln:
                return Math.Round(Math.Log(target.GetValue()), 4);
            
            case OperationType.EpwrX: //e^x
                double sum = 1; 
                double term = 1; // Current term, starts as x^0 / 0! = 1
                int n = 1; // Counter for factorial and power

                while (Math.Abs(term) > 0.0001)
                {
                    term *= target.GetValue() / n; // Compute next term: (x^n / n!)
                    sum += term;   // Add term to the sum
                    n++;           // Increment n for next iteration
                }

                return sum;
        }

        throw new NotSupportedException($"No function type {type} provided for function node.");
    }
}