using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Books bookStore = new Books();
            bookStore.AddBook(new Book("냉정과 열정사이", 10010));
            bookStore.AddBook(new Book("우리들의 행복한 시간", 1002));
            bookStore.AddBook(new Book("블루오션 전략", 1003));
            bookStore.AddBook(new Book("나를 사랑하는 법", 1004));
            
            Console.WriteLine("You have {0} in the store\n", bookStore.BookCount);

            foreach (Book b in bookStore.al)
            {
                Console.WriteLine("PBSN : {0}", b.getID);
                Console.WriteLine("Book Name : {0}", b.getName);
            }
        }
    }
}
