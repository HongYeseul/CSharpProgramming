using System;
using System.Collections;
using System.Threading.Tasks.Dataflow;

namespace Homework2
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
            
            Console.WriteLine(" -- STACK -- ");
            IOperation Stack = new STACK();

            Stack.Insert("First");
            Stack.Insert("Second");
            Stack.Insert("Third");
            Console.WriteLine("GetCurrentElt : "+Stack.GetCurrentElt());
            Console.WriteLine("Search 'No Data' : " + Stack.Search("No Data"));
            Console.WriteLine("Search 'Second' : " + Stack.Search("Second"));
            Console.WriteLine(Stack.Delete());
            Console.WriteLine(Stack.Delete());
            Console.WriteLine("NumOfElements : " + Stack.NumOfElements());
            Console.WriteLine(Stack.Delete());
            
            
            Console.WriteLine(" -- QUEUE -- ");
            IOperation Queue = new QUEUE();

            Queue.Insert("one");
            Queue.Insert("two");
            Queue.Insert("three");
            Console.WriteLine("GetCurrentElt : " + Queue.GetCurrentElt());
            Console.WriteLine("Search 'No Data' : " + Queue.Search("No Data"));
            Console.WriteLine("Search 'Second' : " + Queue.Search("two"));
            Console.WriteLine(Queue.Delete());
            Console.WriteLine(Queue.Delete());
            Console.WriteLine("NumOfElements : " + Queue.NumOfElements());
            Console.WriteLine(Queue.Delete());
            
        }

    }
}
