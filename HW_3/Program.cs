class Program
{
    static void Main(string[] arg)
    {
        Queue<int> Large = new Queue<int>();
        Queue<int> Medium = new Queue<int>();
        Queue<int> Small = new Queue<int>();
        char Size = 'L';
        while (Size == 'S' || Size == 'M' || Size == 'L')
        {
            Size = char.Parse(Console.ReadLine());
            if (Size == 'S')
            {
                Large.Push(3);
            }
            else if(Size == 'M')
            {
                Large.Push(2);
                for (int i = 0 ; i < 3 ; i++)
                {
                    Medium.Push(3);
                }
            }
            else if(Size == 'L')
            {
                Large.Push(1);
                for (int i = 0 ; i < 2 ; i++)
                {
                    Medium.Push(2);
                }
                for (int i = 0 ; i < 6 ; i++)
                {
                    Small.Push(3);
                }    
            }
            Output(Small, Medium, Large);
        }
        static void Output(Queue<int> Small,Queue<int> Medium,Queue<int> Large)
        {
            Console.Write("Output:");
            for(int n = 0;n<Large.GetLength();n++)
            {
                Console.Write("{0}",Large.Get(n));
            }
            for(int n = 0;n<Medium.GetLength();n++)
            {
                Console.Write("{0}",Medium.Get(n));
            }
            for(int n = 0;n<Small.GetLength();n++)
            {
                Console.Write("{0}",Small.Get(n));
            }
            Console.WriteLine("");
            Console.Write("Input: ");
        }
    }
}