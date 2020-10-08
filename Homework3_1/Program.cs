using System;
using System.Collections;
using System.Collections.Generic;

namespace Homework3_1
{
    class Driver<T> : IEnumerable<T>, IEnumerator<T>
    {
        ArrayList array = new ArrayList();
        int position = -1;

        public T this[int index]
        {
            get
            {
                return (T)array[index];
            }
            set
            {
                array.Add(value);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Count; i++)
            {
                yield return ((T)array[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < array.Count; i++)
            {
                yield return (array[i]);
            }
        }
        
        public T Current
        {
            get { return (T)array[array.Count-1]; }
        }

        object IEnumerator.Current
        {
            get { return array[array.Count - 1]; }
        }
        
        public bool MoveNext()
        {
            if (position == array.Count - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Count);
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
            Car Genesis = new Car();
            Genesis.Name = "제네시스";
            Genesis.Value = 40000000;
            Genesis.Cc = 4000;
            Car Opirus = new Car();
            Opirus.Name = "오필러스";
            Opirus.Value = 30000000;
            Opirus.Cc = 2000;
            Car Rio = new Car();
            Rio.Name = "리오";
            Rio.Value = 15000000;
            Rio.Cc = 1000;

            Driver<Car> cars = new Driver<Car>();
            cars[0] = Genesis;
            cars[1] = Opirus;
            cars[2] = Rio;

            foreach (Car temp in cars)
            {
                Console.WriteLine("모델명: " + temp.Name + ", 가격: " + temp.Value + ", 배기량: " + temp.Cc + ", 세금: " + temp.TaxCalc());
            }
        }
    }
}
