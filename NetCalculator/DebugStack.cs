using System;
using System.Collections;
using System.Collections.Generic;

namespace NetCalculator;

public class DebugStack<T> : Stack<T>
{
    public new T Pop()
    {
        T result = base.Pop();

        Console.WriteLine("Popped:" + result.ToString());
        return result;
    }
    
    public new void Push(T obj)
    {
        base.Push(obj);

        Console.WriteLine("Pushed:" + obj.ToString());
    }
}