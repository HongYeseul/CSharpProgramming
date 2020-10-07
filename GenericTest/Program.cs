using System;

namespace GenericTest
{
    class Program
    {
        class MyList<T>
        {
            private T[] array;

            public MyList()
            {
                array = new T[3];
            }

            public T this[int index]
            {
                get
                {
                    return array[index];
                }
                set
                {
                    if (index >= array.Length)
                    {
                        Array.Resize<T>(ref array, index + 1);
                        Console.WriteLine($"Array Resized : {array.Length}");
                    }
                    array[index] = value;
                }
            }

            public int Length
            {
                get { return array.Length; }
            }
        }
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            for(int i=0; i < str_list.Length ; i++)
            {
                Console.WriteLine(str_list[i]); 
            }
        }
    }
}
