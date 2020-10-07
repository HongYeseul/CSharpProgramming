using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Foreach
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] array;
        int position = -1;

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
                if(index >= array.Length)
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

        public IEnumerator<T> GetEnumerator()
        {
            for(int i=0; i<array.Length; i++)
            {
                yield return (array[i]); 
                //yield return은 getEnumerator 동작을 멈추고 return하라는 얘기
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
                //yield return은 getEnumerator 동작을 멈추고 return하라는 얘기
            }
        }

        public T Current
        {
            get { return array[position]; }
        }

        object IEnumerator.Current
        {
            get { return array[position]; }
        }

        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {

        }
    }

    class MainApp {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            foreach (string str in str_list)
                Console.WriteLine(str);

        }

     }
}
