using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_2
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
