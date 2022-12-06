class TreeNode<T>
{
    private string value;
    private TreeNode<string> next = null;
    private TreeNode<string> child = null;

    public TreeNode(string value)
    {
        this.SetValue(value);
    }

    public void SetNext(TreeNode<string> next)
    {
        this.next = next;
    }

    public void SetChild(TreeNode<string> child)
    {
        this.child = child;
    }

    public TreeNode<string> Next()
    {
        return this.next;
    }

    public TreeNode<string> Child()
    {
        return this.child;
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