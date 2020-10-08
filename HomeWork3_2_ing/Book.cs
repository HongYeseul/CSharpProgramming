using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3_2_ing
{
    class Book
    {
        private string name;
        private int number;

        public Book() { }

        public Book(string str, int no)
        {
            this.name = str;
            this.number = no;
        }

        public string getName
        {
            get
            {
                return name;
            }
        }
        public int getID
        {
            get
            {
                return number;
            }
        }
    }
}
