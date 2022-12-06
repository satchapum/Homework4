class Tree<T>
{   
    private TreeNode<string> root = null;
    private int length = 0;

    public void AddSibling(int index, string value)
    {
        TreeNode<string> node = new TreeNode<string>(value);
        TreeNode<string> ptr = this.GetTreeNode(index);
        node.SetNext(ptr.Next());
        ptr.SetNext(node);
        this.length++;
    }

    
    public void GetAddSearchNullNode(int number, string name, int i) {
        int traverseStep = this.length;
        TreeNode<string> ptr = this.GetSearchNullTreeNode(traverseStep);
        ptr.SetValue(name);
        TreeNode<string> node = new TreeNode<string>(null);
        
        string name1 = Console.ReadLine();
        int number1 = int.Parse(Console.ReadLine());

        if(i == 1) {
            ptr.SetChild(node);
            ptr = ptr.Child();
        }
        else {
            ptr.SetNext(node);
            ptr = ptr.Next();
        }
        this.length++;
        if(number == i) {
            for(int x = 1; x <= number1; x++) {
                
                GetAddSearchNullNode(number1, name1, x);
            }
        }

    }
    public void GetOutput(string Input, ref Stack<string> stackinput) {
        TreeNode<string> ptr = this.GetTreeNodeSearch(Input, ref stackinput);
    }
    public void AddChild(int index, string value)
    {
        TreeNode<string> node = new TreeNode<string>(value);
        if(index == -1)
        {
            node.SetChild(this.root);
            this.root = node;
        }
        else
        {
            TreeNode<string> ptr = this.GetTreeNode(index);
            node.SetChild(ptr.Child());
            ptr.SetChild(node);
        }
        this.length++;
    }

    public int GetLength()
    {
        return this.length;
    }

    public string Get(int index)
    {
        TreeNode<string> ptr = this.GetTreeNode(index);
        return ptr.GetValue();
    }
    private TreeNode<string> GetTreeNode(int index)
    {
        int traverseStep = index;
        return this.Traverse(this.root, ref traverseStep);
    }

    private TreeNode<string> GetTreeNodeSearch(string index, ref Stack<string> stackinput)
    {
        return this.Search(this.root, index, ref stackinput);
    }
    private TreeNode<string> GetSearchNullTreeNode(int index)
    {
        int traverseStep = index;
        return this.SearchNullNode(this.root, ref traverseStep);
    }

    private TreeNode<string> Traverse(TreeNode<string> currentTreeNode, ref int traverseStep)
    {
        TreeNode<string> ptr = currentTreeNode;

        if(traverseStep > 0 && currentTreeNode.Child() != null)
        {
            traverseStep--;
            ptr = this.Traverse(currentTreeNode.Child(), ref traverseStep);
        }

        if(traverseStep > 0 && currentTreeNode.Next() != null)
        {
            traverseStep--;
            ptr = this.Traverse(currentTreeNode.Next(), ref traverseStep);
        }

        return ptr;
    }

    public TreeNode<string> Search(TreeNode<string> currentTreeNode, string indexstackinput, ref Stack<string> stackinput)
    {
        
        TreeNode<string> ptr = currentTreeNode;
        //Console.WriteLine(ptr.GetValue());
        if(ptr.GetValue() == indexstackinput){
            for(int roungnumber = 0; roungnumber < stackinput.GetLength(); roungnumber++) {
                Console.WriteLine(stackinput.Get(roungnumber));
            }
            return ptr;
        }

        if(currentTreeNode.Child() != null && ptr.GetValue() != indexstackinput)
        {
            stackinput.Push(ptr.GetValue());
            ptr = this.Search(currentTreeNode.Child(), indexstackinput,ref stackinput);
            if(stackinput.GetLength() != 0){
                stackinput.Pop();
            }
        }

        if(currentTreeNode.Next() != null && ptr.GetValue() != indexstackinput)
        {
            ptr = this.Search(currentTreeNode.Next(), indexstackinput,ref stackinput);
        }

        return ptr;
    }
    public TreeNode<string> SearchNullNode(TreeNode<string> currentTreeNode, ref int traverseStep) {
        
        TreeNode<string> ptr = currentTreeNode;
        if(ptr.GetValue() == null) {
            return ptr;
        }
        if(traverseStep > 0 && currentTreeNode.Child() != null)
        {
            ptr = this.SearchNullNode(currentTreeNode.Child(),ref traverseStep);
        }

        if(traverseStep > 0 && currentTreeNode.Next() != null)
        {
            ptr = this.SearchNullNode(currentTreeNode.Next(),ref traverseStep);
            
        }
        return ptr;
    }
}