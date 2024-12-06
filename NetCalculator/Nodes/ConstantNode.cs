namespace NetCalculator.Nodes;

public class ConstantNode(double constant) : INode
{
    public double GetValue()
    {
        return constant;
    }

}