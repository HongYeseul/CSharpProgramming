using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_2
{
    class Books : Book
    {
        public ArrayList al = new ArrayList();
        private int bookCount = 0;

        public int BookCount
        {
            get
            {
                return bookCount;
            }
        }
        public void AddBook(Book book)
        {
            al.Add(book);
            bookCount++;
        }
    }
}
