class Program {
   
    public static void Main() {

        Tree<string> tree = new Tree<string>();
        tree.AddChild(-1, null);
        tree.GetAddSearchNullNode();

        for(int a =0; a < tree.GetLength(); a++) {
            Console.WriteLine(tree.Get(a));
        }
        
        /*Stack<string> stack = new Stack<string>();
        string nameUnder = Console.ReadLine();
        tree.GetOutput(nameUnder, ref stack);*/
    }
} 
