using System;
using System.Collections;

namespace ConsoleApp1
{
    interface IOperation
    {
        void Insert(string str);
        string Delete();
        bool Search(string str);
        string GetCurrentElt();
        int NumOfElements();
    }

    class QUEUE : IOperation
    {
        ArrayList s = new ArrayList();

        public string Delete()
        {
            string data = (string)s[0];
            s.RemoveAt(0);
            return data;
        }

        public string GetCurrentElt()
        {
            return (string)s[0];
        }

        public void Insert(string str)
        {
            s.Add(str);
        }

        public int NumOfElements()
        {
            return s.Count;
        }

        public bool Search(string str)
        {
            return s.Contains(str);
        }
    }
    class STACK : IOperation
    {
        ArrayList s = new ArrayList();
        public string Delete()
        {
            string data = (string)s[s.Count - 1];
            s.RemoveAt(s.Count - 1);
            return data;
        }

        public string GetCurrentElt()
        {
            return (string)s[s.Count - 1];
        }

        public void Insert(string str)
        {
            s.Add(str);
        }

        public int NumOfElements()
        {
            return s.Count;
        }

        public bool Search(string str)
        {
            return s.Contains(str);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            IOperation Stack = new STACK();
            IOperation Queue = new QUEUE();

            Console.WriteLine(" -- STACK -- ");
            for (int i = 0; i < str.Length; i++)
            {
                Stack.Insert(str[i].ToString());
            }
            int Sn = Stack.NumOfElements();
            Console.WriteLine("STACK NUM OF ELEMENTS : " + Sn);

            for(int i=0; i< Sn; i++)
            {
                Console.Write("STACK " + i + "번째 Delete : ");
                Console.WriteLine(Stack.Delete());
            }

            Console.WriteLine(" -- QUEUE -- ");

            for (int i=0; i< str.Length; i++)
            {
                Queue.Insert(str[i].ToString());
            }
            int Qn = Queue.NumOfElements();
            Console.WriteLine("QUEUE NUM OF ELEMENTS : " + Qn);

            for(int i=0; i<Qn; i++)
            {
                Console.Write("QUEUE " + i + "번째 Delete : ");
                Console.WriteLine(Queue.Delete());
            }

        }
    }
}
