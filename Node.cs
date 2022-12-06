class Node<T>
{
    private string value;
    private Node<string> next = null;

    public Node(string value)
    {
        this.SetValue(value);
    }

    public void SetNext(Node<string> next)
    {
        this.next = next;
    }

    public Node<string> Next()
    {
        return this.next;
    }

    public string GetValue()
    {
        return this.value;
    }

    public void SetValue(string value)
    {
        this.value = value;
    }
}