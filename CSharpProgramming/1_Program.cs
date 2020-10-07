using System;
namespace CSharpProgramming
{
    class Exercise_1
    {
        int @i;
        int [] vector = new int [100];
        int[,] matrix = new int[10,1];
        static int get = 2;
        static int add()
        {
            return get + 2258;
        }
        static void set(int v)
        {
            get = v;
        }

        static void Main(string[] args)
        {
            object o = get;
            int i = (int)o;
            Console.WriteLine("Exercise_1.get={0}", Exercise_1.get);
            Console.WriteLine("Exercise_1.get={0}", Exercise_1.add());
            Exercise_1.set(3343);
            Console.WriteLine("Exercise_1.get={0}", Exercise_1.get);
        }
    }
    
}
