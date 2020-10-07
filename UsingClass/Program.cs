using System;

namespace UsingClass
{
    class Base
    {
        public Base() { Console.WriteLine("I am base class."); }
        public void Print()
        {
            Console.WriteLine("Overriding TEST >> Im base method, print");
        }
        protected int a, b, c;
        public void init(int x, int y)
        {
            this.a = x;
            this.b = y;
        }
        public void show()
        {
            Console.WriteLine("C = {0}", c);
        }
    }

    class Add : Base
    {
        public Add() { Console.WriteLine("im add class"); }

        public void Print()
        {
            Console.WriteLine("Overriding Test Im Add method Print()");
        }
        public void addition()
        {
            c = a + b;

        }
    }

    class Mul : Base
    {
        public Mul()
        {
            Console.WriteLine("im mul class");
        }
        public void multiplication()
        {
            c = a * b;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Add x = new Add();
            x.init(5, 7);

            Mul y = new Mul();
            y.init(3, 5);

            x.addition();
            x.show();

            y.multiplication();
            y.show();

            x.Print();
            Base b = x;
            b.Print();

            y.Print();
        }
    }
}
