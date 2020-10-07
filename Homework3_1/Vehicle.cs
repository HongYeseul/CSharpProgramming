using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3_1
{
    class Vehicle
    {
        private string name;
        private int value;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }
        public virtual float TaxCalc() { return (float)0.0; }
    }
}
