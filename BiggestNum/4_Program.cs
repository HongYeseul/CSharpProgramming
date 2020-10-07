using System;

namespace BiggestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.MinValue;
            int flag = 1;

            while( flag != 0)
            {
                Console.Write("정수 1개 입력 : ");
                flag = Int32.Parse( Console.ReadLine());
                if (num <= flag && flag != 0)
                    num = flag;
            }

            Console.WriteLine("제일 큰 수는 " +num);
        }
    }
}
