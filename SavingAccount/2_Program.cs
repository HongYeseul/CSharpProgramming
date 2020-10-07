using System;

namespace SavingAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("원금 입력");
            string s = Console.ReadLine();
            int money = Int32.Parse(s);
            
            Console.WriteLine("이율 입력");
            s = Console.ReadLine();
            float rate = float.Parse(s);
            
            Console.WriteLine("기간 입력");
            s = Console.ReadLine();
            int time = Int32.Parse(s);

            float sum;
            sum = money * (float)Math.Pow((1 + rate), time);
            Console.WriteLine( "복리법에 의한 합계 : " + sum + "원" );
        }
    }
}
