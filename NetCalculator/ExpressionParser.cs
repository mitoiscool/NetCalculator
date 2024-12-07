using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using NetCalculator.Nodes;
using NetCalculator.Nodes.Arithmetic;
using NetCalculator.Nodes.Function;

namespace NetCalculator;

public class ExpressionParser
{
    private DebugStack<INode> _expressionStack = new DebugStack<INode>();
    private DebugStack<OperationType> _operatorStack = new DebugStack<OperationType>();
    private StringBuilder _constantBuilder = new StringBuilder();

    public void OpenParenthesis()
    {
        MarkEndConstant();

        _operatorStack.Push(OperationType.Parenthesis);
    }

    public void CloseParenthesis()
    {
        MarkEndConstant();
        
        while (_operatorStack.Count > 0 && _operatorStack.Peek() != OperationType.Parenthesis)
        {
            ProcessOperator();
        }

        if (_operatorStack.Count == 0 || _operatorStack.Pop() != OperationType.Parenthesis)
        {
            throw new InvalidOperationException("Unmatched closing parenthesis.");
        }
    }

    public void Constant(string s)
    {
        _constantBuilder.Append(s);
    }

    public string GetLastConstant()
    {
        return _constantBuilder.ToString();
    }

    public void Operation(OperationType type)
    {
        MarkEndConstant();
        
        // if it is a function I could impl implicit multiplication on them such as "5ln(2)" or something, this is a confusing error with the syntax for users

        while (_operatorStack.Count > 0 &&
               Precedence(type) <= Precedence(_operatorStack.Peek())) // ensure precedence when processing ops
        {
            ProcessOperator();
        }

        _operatorStack.Push(type);
    }

    public double Evaluate()
    {
        MarkEndConstant();

        while (_operatorStack.Count > 0)
        {
            ProcessOperator();
        }

        double result = 1; // set to one for the purposes of multiplying in later block, it will be reset anyway in other block
        if (_expressionStack.Count > 1)
        {
            // they should be multiplied implicitly ex: 4ln

            while (_expressionStack.Count > 0)
            {
                result *= _expressionStack.Pop().GetValue();
            }
        }
        else
        { // more simple, no implicit mult
            var finalNode = _expressionStack.Pop();
            result = finalNode.GetValue();
        }

        Reset();

        return result;
    }

    public void MarkEndConstant()
    {
        if (_constantBuilder.Length == 0)
            return; // we can let error occur on evaluation later

        if (!double.TryParse(_constantBuilder.ToString(), out double value))
        {
            throw new DataException($"Unable to parse constant: " + _constantBuilder.ToString());
        }

        _expressionStack.Push(new ConstantNode(value));
        _constantBuilder.Clear();
    }

    public void Reset()
    {
        _expressionStack.Clear();
        _operatorStack.Clear();
        _constantBuilder.Clear();
    }

    private void ProcessOperator()
    {
        if (_operatorStack.Count == 0) // ensure that args are all good
        {
            throw new InvalidOperationException("No operator");
        }
        
        var opType = _operatorStack.Pop();

        if (opType.IsFunction())
        {
            var op1 = _expressionStack.Pop();
            _expressionStack.Push(new FunctionNode(op1, opType));
        }
        else
        {
            var op2 = _expressionStack.Pop();
            var op1 = _expressionStack.Pop(); // stack is LIFO so pop operand 2 first

            _expressionStack.Push(new ArithmeticNode(op1, op2, opType));
        }
        
        
    }

    int Precedence(OperationType type)
    {
        return type switch
        {
            OperationType.Parenthesis => 0,
            OperationType.Ln or OperationType.EpwrX => 4, // only because they are direct one args therefore should take place of next constant instantly
            OperationType.Pwr or OperationType.Rt => 3,
            OperationType.Mul or OperationType.Div or OperationType.Log or OperationType.Ln or OperationType.EpwrX => 2,
            OperationType.Add or OperationType.Sub => 1,
            _ => throw new ArgumentOutOfRangeException(nameof(type), $"Unexpected type: {type}")
        };
    }
}