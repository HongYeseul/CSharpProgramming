using System;
namespace _19._05._24
{
    delegate int MyDelegate(int a);

    class Market
    {
        int values = 1;
        public event MyDelegate CustomerEvent;
        public int BuySomething(int CustomerNo)
        {
            if (CustomerNo == 30)
            {
                values = CustomerEvent(CustomerNo);
            }
            return values;
        }
    }
    class Program
    {
        static public int MyHandler(int a)
        {
            Console.WriteLine($"축하합니다! {a}번째 고객 이벤트에 당청되셨습니다.");
            return a;
        }
        static void Main(string[] args)
        {
            Market market = new Market();
            int value = -1;
            market.CustomerEvent += new MyDelegate(MyHandler);
            for (int customerNo = 0; customerNo < 100; customerNo += 10)
            {
                value = market.BuySomething(customerNo);
            }
            Console.Write(value);
        }
    }
}