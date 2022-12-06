class Program {
   
    public static void Main() {

        Tree<string> tree = new Tree<string>();
        tree.AddChild(-1, null);
        tree.GetAddSearchNullNode();
        
        Stack<string> stack = new Stack<string>();
        string nameUnder = Console.ReadLine();
        tree.GetOutput(nameUnder, ref stack);
    }
} 
