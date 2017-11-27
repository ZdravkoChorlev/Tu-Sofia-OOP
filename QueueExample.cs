using System;
using System.Linq;
using System.Collections.Generic;

class StackExample
{
    public List<string> container = new List<string>();
    public void Push(string value)
    {
        container.Add(value);
    }
    public string Pop()
    {
        string popped = container[container.Count - 1];
        container.RemoveAt(container.Count - 1);
        return popped;
    }

    public bool Empty
    {
        get { return container.Count == 0; }
    }

    public StackExample()
    {
        this.container = new List<string>();
    }
}