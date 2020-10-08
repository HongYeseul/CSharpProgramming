using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3_2_ing
{
    class Books : Book
    {
        public List<Book> al = new List<Book>();
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

        public void RemoveBook(int index)
        {
            al.RemoveAt(index-1);
            bookCount--;
        }
        
        public bool BookIsPresent(Book temp)
        {
            return al.Contains(temp);
        }

        public void ClearAllBooks()
        {
            al.Clear();
            bookCount = 0;
        }
    }

   
}
