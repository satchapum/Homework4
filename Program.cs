class Program {
   
    public static void Main() {

        Tree<string> tree = new Tree<string>();
        tree.AddChild(-1, null);
        int i = 1;
        string Name = Console.ReadLine(); 
        int NumberUnder = int.Parse(Console.ReadLine());
        tree.GetAddSearchNullNode(NumberUnder, Name, i);

        for(int a =1; i <= NumberUnder; i++) {
            string Name1 = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            tree.GetAddSearchNullNode(number, Name1, a);
        }
        for(int a =0; a <= tree.GetLength(); a++) {
            Console.WriteLine(tree.Get(a));
        }
        
        Stack<string> stack = new Stack<string>();
        string nameUnder = Console.ReadLine();
        tree.GetOutput(nameUnder, ref stack);
    }
} 
