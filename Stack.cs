class Stack<T>
{
    private Node<string> top = null;
    private int length = 0;

    public void Push(string value)
    {
        Node<string> node = new Node<string>(value);
        node.SetNext(this.top);
        this.top = node;
        this.length++;
    }

    public string Pop()
    {
        Node<string> node = this.top;
        this.top = this.top.Next();
        this.length--;
        return node.GetValue();
    }

    public string Get(int index)
    {
        Node<string> ptr = this.GetNode(index);
        return ptr.GetValue();
    }

    public int GetLength()
    {
        return this.length;
    }

    private Node<string> GetNode(int index)
    {
        Node<string> ptr = this.top;
        while(index > 0)
        {
            ptr = ptr.Next();
            index--;
        }
        return ptr;
    }
}