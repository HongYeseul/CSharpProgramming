using System;
using System.Collections;

namespace Indexer_TEST
{

    class SimpleIndexer
    {
        ArrayList lname = new ArrayList();

        public object this[int index]
        {
            get
            {
                if (index > -1 & index < lname.Count)
                    return lname[index];
                else
                {
                    Console.WriteLine("sid[" + index + "]는 없습니다.");
                    return null;
                }
            }
            set
            {
                if (index > -1 & index < lname.Count)
                {
                    lname[index] = value;
                }
                else if(index == lname.Count)
                {
                    Console.WriteLine("lname.Count = {0}", lname.Count);
                    lname.Add(value);
                }
                else
                {
                    Console.WriteLine("sid[" + index + "] : 입력 범위 초과 에러");
                }
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpleIndexer sid = new SimpleIndexer();
            sid[0] = "Choi";
            sid[1] = "LEE";
            sid[2] = "CHO";
            sid[4] = "PARK";

            Console.WriteLine(sid[0]);
            Console.WriteLine(sid[1]);
            Console.WriteLine(sid[2]);
            Console.WriteLine(sid[4]);
        }
    }
}
